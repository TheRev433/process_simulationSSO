using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace process_simulation
{
    public partial class Form1 : Form
   {
        string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "finished_process.txt";
        int currentProcessMWT;
        public int currentBatch = 0;
        public int lastTime = 0;
        public Random rnd = new Random();
        public List<string> names = new List<string>();
        public List<string> ops = new List<string>();
        public int batchN;
        public int n_process;
        public ListProcess processList = new ListProcess();
        public ListProcess standbyProcess = new ListProcess();
        public ListProcess finishedProcess = new ListProcess();
        public ProcessClass runningProcess;
        public Form1()
        {
            InitializeComponent();
            this.names.Add("Jose");
            this.names.Add("Carlos");
            this.names.Add("Carolina");
            this.names.Add("Juan");
            this.ops.Add("+");
            this.ops.Add("-");
            this.ops.Add("*");
            this.ops.Add("/");
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            this.n_process = Int32.Parse(nProcessTextBox.Text);
            this.generateProcess();
        }
        public void generateProcess()
        {
            this.batchN = this.n_process / 6;
            if (n_process%6 > 0)
            {
                this.batchN += 1;
            }
            this.batchCountLabel.Text ="# Batch: " + this.batchN.ToString();
            for (int i=0; i<this.n_process; i++)
            {
                if (i == 0)
                { 
                    this.processList.Add(new ProcessClass(0, this.rnd.Next(0, 100), this.rnd.Next(0, 100), 0, this.rnd.Next(4, 7), this.names[this.rnd.Next(this.names.Count)], this.ops[this.rnd.Next(this.ops.Count)]));
                }
                else
                {
                    this.processList.Add(new ProcessClass(this.processList.Last().id+1, this.rnd.Next(0, 100), this.rnd.Next(0, 100), 0, this.rnd.Next(4, 7), this.names[this.rnd.Next(this.names.Count)], "+"));
                }
            }
            this.run();
        }
        public void getStandbyList()
        {
            this.finishedListBox.Items.Add("Batch " + (this.currentBatch + 1));
            //Move process from current batch into the standby list.
            if (this.n_process - this.finishedProcess.Count >= 6)
            {
                this.standbyProcess.AddRange(this.processList.GetRange(this.finishedProcess.Count, 6));
            }
            else
            {
                this.standbyProcess.AddRange(this.processList.GetRange(this.finishedProcess.Count, this.n_process- this.finishedProcess.Count));
            }
        }

        public void run()
        {
            this.getStandbyList();
            this.currentBatch = 1;
            this.moveToRunning();
            this.ProcessTimer.Enabled = true;
        }
        public void moveToRunning()
        {
            //select new process to run
            this.runningProcess = this.standbyProcess.First();
            this.currentProcessMWT = this.runningProcess.time;
            //remove that process from standby
            this.standbyProcess.RemoveAt(0);

            //Print first standby process on the ListView if there is at least one process
            if (this.standbyProcess.Count > 0)
            {
                ProcessClass firstStandbyProcess = this.standbyProcess.First();
                this.standbyListView.Items.Add(new ListViewItem(new string[] { firstStandbyProcess.id.ToString(), firstStandbyProcess.name, firstStandbyProcess.time.ToString(), this.standbyProcess.Count.ToString(), (this.batchN - currentBatch).ToString() }));
            }
            //Print running process on the ListView
            this.runningListView.Items.Add(new ListViewItem(new string[] { this.runningProcess.id.ToString(), this.runningProcess.name,
                    this.runningProcess.time.ToString(), this.runningProcess.n1.ToString() + this.runningProcess.op + this.runningProcess.n2.ToString() }));

        }

        public void finishingProcess()
        {
            switch(this.runningProcess.op)
            {
                case "+":
                    this.runningProcess.result = this.runningProcess.n1 + this.runningProcess.n2;
                    break;
                case "-":
                    this.runningProcess.result = this.runningProcess.n1 - this.runningProcess.n2;
                    break;
                case "*":
                    this.runningProcess.result = this.runningProcess.n1 * this.runningProcess.n2;
                    break;
                case "/":
                    this.runningProcess.result = this.runningProcess.n1 / this.runningProcess.n2;
                    break;
                default:
                    break;
            }
            //after waiting, move the running process to finished process list
            this.finishedProcess.Add(this.runningProcess);
            this.finishedListBox.Items.Add(this.runningProcess.id.ToString() + " - " + this.runningProcess.n1.ToString() + this.runningProcess.op + this.runningProcess.n2.ToString() + "=" + this.runningProcess.result.ToString());
            this.finishedListView.Items.Add(new ListViewItem(new string[] 
            {
                this.runningProcess.id.ToString(), this.runningProcess.n1.ToString() + this.runningProcess.op + this.runningProcess.n2.ToString() + "=" + this.runningProcess.result.ToString()
            }));
            //clear running and standby lists
            this.runningListView.Items.Clear();
            this.standbyListView.Items.Clear();
        }

        public void writeToFile()
        {
            TextWriter text_file = new StreamWriter("Process.txt");
            List<string> lines = new List<string>();
            foreach(string item in this.finishedListBox.Items)
            {
                text_file.WriteLine(item);
            }
            text_file.Close();
            
        }
        private void ProcessTimer_Tick(object sender, EventArgs e)
        {
            this.runningProcess.time -= 1;
            this.runningListView.Items[0].SubItems[2].Text = this.runningProcess.time.ToString();
            int currentTime = Int32.Parse(this.timerLabel.Text) + 1;
            this.timerLabel.Text = currentTime.ToString();
            if(this.runningProcess.time <=0)
            {
                this.lastTime = currentTime;
                this.finishingProcess();
                if(this.standbyProcess.Count > 0) // There are more process on this batch
                {
                    this.moveToRunning();
                }
                else if (this.finishedProcess.Count == this.n_process) // if all process have been completed
                {
                    this.writeToFile();
                    this.ProcessTimer.Stop();
                }
                else // Standby list is empty but there are more batch
                {
                    this.getStandbyList();
                    this.moveToRunning();
                    currentBatch += 1;
                }
            }
        }
    }
}
