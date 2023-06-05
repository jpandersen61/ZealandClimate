using System;
using System.Collections.Generic;
using System.Text;

namespace ZealandClimate
{
    class Measurement:IDBase
    {
        //private int _id;
        private DateTime _dateTime;
        private double _temp;
        private int _co2;
        private int _numberOfPersons;

        public Measurement(DateTime dateTime,
                           double temp,
                           int co2,
                           int numberOfPersons):base()
        {
            TestException(temp);
            //_id = id;
            _dateTime = dateTime;
            _temp = temp;
            _co2 = co2;
            _numberOfPersons = numberOfPersons;
        }

        /*public int Id
        {
            get { return _id; }
            set { _id = value; }
        }*/

        public DateTime DateTime
        {
            get { return _dateTime;}
            set { _dateTime = value; }
        }

        public double Temp
        {
            get { return _temp; }
            set {
                    TestException(value);
                   _temp = value; }
                 }

        public int Co2
        {
            get { return _co2; }
            set { _co2 = value; }
        }

        public int NumberOfPersons
        {
            get { return _numberOfPersons; }
            set { _numberOfPersons = value; }
        }

        void TestException(double temp)
        {
            if (temp < 0 || temp > 50)
            {
                throw new ArgumentException("Temp outside range");
            }
        }

        public override string ToString()
        {
            return $"Id: {ID}, DateTime: {DateTime}, Temp: {Temp}, Co2: {Co2}, NumberOfPersons: {NumberOfPersons}";
        }
    }
}
