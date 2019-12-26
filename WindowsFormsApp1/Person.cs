using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Person
    {
        public string name;
        public int weigh;
        public int initFloor;
        public int destFloor;
        Elevator elevator;
        Building building;
        public States state;
        public Person(string n, int w, int iF, int dF, Elevator el, Building b)
        {
            name = n;
            weigh = w;
            initFloor = iF;
            destFloor = dF;
            elevator = el;
            building = b;
            state = States.waitsForLift;
            Thread myThread = new Thread(thread);
            myThread.Start();
        }

        private void thread()
        {
            Thread.Sleep(1524);
            elevator.callAt(initFloor);
            while (true)
            {
                Thread.Sleep(100);
                if (elevator.isAt(initFloor)) break;
            }
            elevator.enter(this);
            state = States.insideTheElevator;
            elevator.pushDestBtn(destFloor);
            if (!building.sbElseGoingIn(initFloor))
            {
                if(!elevator.run())
                {
                    state = States.gaveUp;
                    elevator.leave(this);
                    Thread.Sleep(5000);
                    building.leaveSystem(this);
                    return;
                }
            }
            while (true)
            {
                Thread.Sleep(100);
                if (elevator.isAt(destFloor))
                {
                    elevator.leave(this);
                    state = States.carriedToDestFloor;
                    Thread.Sleep(5000);
                    building.leaveSystem(this);
                    break;
                }
            }
            return;
        }

    }


    public enum States
    {
        waitsForLift,
        insideTheElevator,
        carriedToDestFloor,
        gaveUp
    }
}
