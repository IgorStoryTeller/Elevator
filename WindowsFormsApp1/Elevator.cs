using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace WindowsFormsApp1
{
    public class Elevator
    {
        private bool[] innerBtns;
        private bool[] outerBtns;
        private bool Run;
        private List<Person> carriedPeople;
        public int totalWeigh { set; get; }
        private int currentWeigh;
        private int maxWeigh;
        private int currentFloor;
        public Thread myThread;
        public bool Running { set; get; }
        
        public Elevator(int nofFloors)
        {
            innerBtns = new bool[nofFloors];
            outerBtns = new bool[nofFloors];
            Run = false;
            maxWeigh = 400;
            totalWeigh = 0;
            currentFloor = 1;
            carriedPeople = new List<Person>();

            myThread = new Thread(thread);
            Running = true;
            myThread.Start(); 

        }
        public void callAt(int floor)
        {
            outerBtns[floor-1] = true;
        }
        public void pushDestBtn(int floor)
        {
            innerBtns[floor-1] = true;
        }
        private void thread()
        {
            while(Running)
            {
                Thread.Sleep(1000);
                if(targetFloorExists())
                {
                    if(currentFloor<targetFloor())
                    {
                        currentFloor++;
                    }
                    else if (currentFloor == targetFloor())
                    {
                        Run = false;
                        outerBtns[currentFloor - 1] = false;
                        innerBtns[currentFloor - 1] = false;
                        while (!Run) Thread.Sleep(100);
                    }
                    else if (currentFloor > targetFloor())
                    {
                        currentFloor--;
                    }
                }
                
            }
        }
        private int targetFloor()
        {
            int whereToStop=0;
            for(int i = 0;i<outerBtns.Length;i++)
            {
                if (outerBtns[i] == true)
                {
                    whereToStop = i+1;
                    break;
                }
            }
            for (int i = 0; i < innerBtns.Length; i++)
            {
                if (innerBtns[i] == true)
                {
                    whereToStop = i + 1;
                    break;
                }
            }
            return whereToStop;
        }
        private bool targetFloorExists()
        {
            foreach(bool z in innerBtns)
            {
                if (z == true) return true;
            }
            foreach (bool z in outerBtns)
            {
                if (z == true) return true;
            }
            return false;
        }
        public bool isAt(int floor)
        {
            return currentFloor == floor ? true : false;
        }
        public void enter(Person p)
        {
            carriedPeople.Add(p);
            totalWeigh += p.weigh;
        }
        public void leave(Person p)
        {
            carriedPeople.Remove(p);
        }
        private bool isOverloaded()
        {
            currentWeigh = 0;
            foreach(Person p in carriedPeople)
            {
                currentWeigh += p.weigh;
            }
            if (maxWeigh < currentWeigh) return true;
            else return false;
        }
        public bool run()
        {
            if (isOverloaded()) return false;
            else
            {
                Run = true;
                return true; 
            }
        }
        public int getCurrentFloor()
        {
            return currentFloor;
        }
    }
}
