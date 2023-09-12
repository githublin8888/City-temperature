using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather
{
    internal class City
    {
        public string name; //declare two attributes: the name of city, the temperature
        public int temp;

        public static void aCity(string[] name, int[] temp)//user types in name and temperature
        {
            for (int i = 0; i < name.Length; i++)
            {
                Console.Write("Type in a city: ");
                string city = Console.ReadLine();
                Console.Write("Type in the temperature of " + city + " :");
                int Ctemp = Convert.ToInt32(Console.ReadLine());
                name[i] = city;
                temp[i] = Ctemp;
            }
        }

        static void TempSorts(int[] temp, string[] name) // to sort the cities according to the order of temperature
        {            
            int n=temp.Length-1;
            for (int i=0; i < n; i++)//an outer loop to go through the list of four cities
            {
                int nrLeft= n - i;
                for (int j=0; j<nrLeft; j++)//an inner loop to go through element for element and compare city temperatures
                {
                    if (temp[j] > temp[j+1])
                    {
                        int blank=temp[j];
                        temp[j]= temp[j+1];
                        temp[j+1]= blank;
                    }
                }
            }
            for(int i=0; i < temp.Length; i++)
            {
                Console.WriteLine("The temperature of "+name[i]+" : "+ temp[i]);
            }
                
        }

        static int LinearSearch(string[] name, int[] temp, int searchTemp)//to search a certain temperature
        {
            
            for (int i = 0; i < name.Length; i++)
            {

                if (temp[i] == searchTemp)
                    return i;
            }
            return -1;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!");
            string[] name = new string[4];
            int[] temp = new int[4];
                        
            aCity(name, temp);
            TempSorts(temp, name);
            Console.WriteLine("Please type in a search temperature: ");
            int searchTemp = Convert.ToInt32(Console.ReadLine());
            int index= LinearSearch(name, temp, searchTemp);
            if (index == -1)
                Console.WriteLine("The temperature does not exists in the list.");
            else 
                Console.WriteLine("The city with temperature " + searchTemp + " is " + name[index]);


        }

    }
    
}
