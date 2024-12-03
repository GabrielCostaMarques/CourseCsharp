﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCsharp.Vetores
{
    public class VetorUser()
    {

      public void VetorShow()
        {
        int n = int.Parse(Console.ReadLine());

        double[] vect = new double[n];

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum =0;
            for (int i = 0; i < n; i++)
            {
                sum+= vect[i];
            }

            double avg = sum/n;

            Console.WriteLine("Average Height: "+avg.ToString("f2"));
        }
    }
}
