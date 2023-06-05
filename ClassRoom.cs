using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ZealandClimate
{
    class ClassRoom:IDBase
    {
        //Moved to base class: private int _id;
        //Moved to base class: private static int _nextID = 0;
        private List<Measurement> _measurements;
        private string _roomNumber;
        private int _maxNumberOfPersons;
        
        public ClassRoom(string roomNumber, int maxNumberOfPersons):base()
        {
            //Moved to base class: _nextID++;
            //Moved to base class: _id = _nextID;
            _roomNumber = roomNumber;
            _maxNumberOfPersons= maxNumberOfPersons;
            _measurements = new List<Measurement>();
        }

        /*Moved to base class: 
        public int ID 
        {
            get { return _id; }
        }
        */

        public string RoomNumber
        {
            get { return _roomNumber; }
            set { _roomNumber = value; }
        }

        public int  MaxNumberOfPersons
        {
            get { return _maxNumberOfPersons; }
            set { _maxNumberOfPersons = value; }
        }

        public override string ToString()
        {
            return $"ID: {ID}, RoomNumber: {RoomNumber}, MaxNumberOfPersons: {MaxNumberOfPersons}";
        }

        public void Add(Measurement measurement)
        {
            _measurements.Add(measurement);
        }
    }
}
