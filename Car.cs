﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClassesExercise
{
    public class Car
    {

        public Car ( string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
            
        }
        //Constructors
        public Car()// - a special member method that has the same name as its class
        {

        }

        //fields
        //Properties
        //Methods

        //Create a Make property of typr=r string that is public
        public string Make { get; set; }// get = read set = write
        public string Model { get; set; }

        public int Year { get; set; }



    }
   

    


