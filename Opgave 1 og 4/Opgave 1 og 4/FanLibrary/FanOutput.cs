using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace FanLibrary
{
    public class FanOutput
    {
        private double _fugt;
        private string _navn;
        private double _grader;

        public int Id { get; } = IdCounter;
        public static int IdCounter = 1;


        public string Navn
        {
            get => _navn;
            set
            {
                if (value.Length >= 2)
                {
                    _navn = value;
                }

                else
                {
                    throw new Exception ("Name is to short");
                    
                }
            } 
        }


        public double Grader
        {
            get => _grader;
            set
            {
                if (value >= 15 && value <= 25)
                {
                    _grader = value;
                }

                else
                {
                    throw new Exception("Value is out of the accepted range");
                }
            }
        }


        public double Fugt
        {
            get => _fugt;
            set
            {
                if (value >= 30 && value <= 80)
                {
                    _fugt = value;
                }

                else
                {
                    throw new Exception("Value is out of accepted range");
                }

            } 
        }

        public FanOutput()
        {
            
        }

        public FanOutput(string navn, double grader, double fugt)
        {
            Id = IdCounter++;
            Navn = navn;
            Grader = grader;
            Fugt = fugt;

        }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Navn)}: {Navn}, {nameof(Grader)}: {Grader}, {nameof(Fugt)}: {Fugt}";
        }
    }
}
