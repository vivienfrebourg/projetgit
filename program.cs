/*-----------------------
----- Program.cs --------
-----------------------*/

/* Ajout d'une ligne pour l'exemple de modification */

/* Ligne pr�sente dans la branche "uneBranche" mais pas dans la branche "master" */
/* Autre modification ligne 8 mais dans la branche master */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesDifferentsTris
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = new string[] { "toto" , "titi", "tutu" };
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write(data[i] + " ");
            }
            data = SortingAlgortihms.ComputeArray(data, SortingAlgortihms.SortingTypes.InsertionSort);

            for(int i = 0; i < data.Length; i++)
            {
                Console.Write(data[i]+ " "); 
            }

            data = new string[] { "toto", "titi", "tutu" };
            data = SortingAlgortihms.ComputeArray(data, SortingAlgortihms.SortingTypes.BubbleSort);

            for (int i = 0; i < data.Length; i++)
            {
                Console.Write(data[i] + " ");
            }

            data = new string[] { "toto", "titi", "tutu" };
            data = SortingAlgortihms.ComputeArray(data, SortingAlgortihms.SortingTypes.BubbleSort);

            for (int i = 0; i < data.Length; i++)
            {
                Console.Write(data[i] + " ");
            }


            Console.ReadLine();
        }
    }
}
