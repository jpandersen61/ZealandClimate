using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ZealandClimate
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assignment 1
            ClassRoom cr1 = new ClassRoom("#1", 24);
            ClassRoom cr2 = new ClassRoom("#2", 24);

            Measurement m1 = new Measurement(DateTime.Now, 24.1, 620, 26);
            
            cr1.Add(m1);            
            Console.WriteLine(m1);

            //Assignment 4
            MeasurementRegister mr = new MeasurementRegister();

            //Assignment 5
            mr.CreateMeasurement(24,1203,23);
            mr.CreateMeasurement(21, 950, 25);
            mr.CreateMeasurement(22, 354, 19);
            
            Console.WriteLine();
            Console.WriteLine("Assignment 5");
            Console.WriteLine("Printing measurements");
            mr.PrintAllMeasurements();
            Console.WriteLine("Getting measurement");
            Console.WriteLine(mr.GetMeasurement(4));

            //Assignment 6
            Console.WriteLine();
            Console.WriteLine("Assignment 6");
            Console.WriteLine($"Number of illegal CO2 meas: {mr.NumberOfIllegalCO2Measurements()}");

            //Assigment 11
            Console.WriteLine();
            Console.WriteLine("Assignment 11");
            try
            {
                new Measurement(DateTime.Now, 250, 1000, 25);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
