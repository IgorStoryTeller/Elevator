using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Building building;
        Elevator elevator;
        Thread thr;

        public Form1()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            int p = int.Parse(nofPeopleTextBox.Text);
            int f = int.Parse(nofFloorsTextBox.Text);
            building = new Building(p,f);
            elevator = building.elevator;
            thr = new Thread(usrInfThread);
            thr.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            building.stop();
            summaryForm sum1 = new summaryForm(elevator);
            sum1.Show();

            
        }


        private void addUsrBtn_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            int w = int.Parse(weighTextBox.Text);
            int iF = int.Parse(initFloorTextBox.Text);
            int dF = int.Parse(destFloorTextBox.Text);
            building.addPerson(name, w, iF, dF);
        }
        public void setCurFloorLabel()
        {
            curFloorLabel.Text = elevator.getCurrentFloor().ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void usrInfThread()
        {
            int n = 8;
            Label[] labels = new Label[n];
            for(int i = 0;i<n;i++)
            {
                labels[i] = new Label();
                labels[i].Location = new Point(10, (i + 1) * 20);
                addLabelSafe(labels[i]);
            }
            while (true)
            {
                for (int i = 0; i < building.people.Count; i++)
                {
                    string state = "error";
                    switch (building.people[i].state)
                    {
                        case States.waitsForLift:
                            state = building.people[i].name + " is waiting at " + building.people[i].initFloor.ToString();
                            break;
                        case States.insideTheElevator:
                            state = building.people[i].name + " is inside at " + building.elevator.getCurrentFloor().ToString();
                            break;
                        case States.carriedToDestFloor:
                            //state = building.people[i].name + " has been carried to " + building.people[i].destFloor.ToString();
                            state = "AHAHAHAHAHAHAHAHAHA";
                            break;
                        case States.gaveUp:
                            state = building.people[i].name + " gave up";
                            break;
                    }
                    writeTextSafe(labels[i], state);                 
                }
                for(int i = building.people.Count;i<n;i++)
                {
                    writeTextSafe(labels[i], "");
                }
                Thread.Sleep(138);

            }

        }
        private delegate void SafeCallDelegate(Label usrlabel);
        private void addLabelSafe(Label usrlabel)
        {
            if (this.usrsInfGBox.InvokeRequired)
            {
                var d = new SafeCallDelegate(addLabelSafe);
                this.usrsInfGBox.Invoke(d, new object[] { usrlabel });
            }
            else
            {
                this.usrsInfGBox.Controls.Add(usrlabel);
            }
        }

        private delegate void SafeCallDelegate2(Label usrlabel, string text);
        private void writeTextSafe(Label usrlabel, string text)
        {
            if (usrlabel.InvokeRequired)
            {
                var d = new SafeCallDelegate2(writeTextSafe);
                usrlabel.Invoke(d, new object[] {usrlabel, text });
            }
            else
            {
                usrlabel.Text = text;
            }
        }



        private void usrsInfGBox_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            thr.Abort();
            building.elevator.myThread.Abort();
        }
    }



}

