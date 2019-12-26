using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Building
    {
        int nofPeople;
        int nofFloors;
        public Elevator elevator;
        public List<Person> people;

        public Building(int p, int f)
        {
            nofPeople = p;
            nofFloors = f;
            elevator = new Elevator(nofFloors);
            people = new List<Person>();
        }

        public void stop()
        {
            elevator.Running = false;
        }

        public void addPerson(string name, int w, int iF, int dF)
        {
            people.Add(new Person(name,w,iF,dF,elevator,this));
        }

        public bool sbElseGoingIn(int floor)
        {
            foreach(Person p in people)
            {
                if (p.initFloor == floor && p.state == States.waitsForLift) return true;
            }
            return false;
        }
        public void leaveSystem(Person p)
        {
            people.Remove(p);
        }
    }













}
