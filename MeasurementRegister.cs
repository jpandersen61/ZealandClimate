using System;
using System.Collections.Generic;
using System.Text;

namespace ZealandClimate
{
    class MeasurementRegister
    {
        private List<Measurement> _measurements;

        public MeasurementRegister()
        {
            _measurements = new List<Measurement>();
        }

        public MeasurementRegister(List<Measurement> measurements)
        {
            _measurements = measurements;
        }

        public void CreateMeasurement(double temp, int co2, int numberOfPerson)
        {
            _measurements.Add(new Measurement(DateTime.Now, temp,co2,numberOfPerson));
        }

        public Measurement GetMeasurement(int id)
        {
            if (_measurements == null)
                return null;
            
            foreach (Measurement m in _measurements)
            {
                if (m.ID == id)
                    return m;
            }

            return null;
        }

        public void PrintAllMeasurements()
        {
            if (_measurements == null)
                return;

            foreach (Measurement m in _measurements)
            {
                Console.WriteLine(m);
            }
        }

        public int NumberOfIllegalCO2Measurements()
        {
            int result = 0;

            if (_measurements == null)
                return result;

            foreach (Measurement m in _measurements)
            {
                if (m.Co2 > 1000)
                    result++;
            }

            return result;
        }



    }
}
