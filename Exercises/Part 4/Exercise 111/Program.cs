using System;
using System.Collections.Generic;

namespace exercise_111
{
    class Program
    {
        public static void Main(string[] args)
        {
            // IMPLEMENT YOUR CODE IN HERE!
            List<PersonalInformation> list = new List<PersonalInformation>();

            while (true)
            {
                Console.WriteLine("First name:");
                string fname = Console.ReadLine();
                if (fname == ""){
                break;
                }
                Console.WriteLine("Last name: ");
                string sname = Console.ReadLine();
                Console.WriteLine("Identification number: ");
                string inumber = Console.ReadLine();

                list.Add(new PersonalInformation(fname, sname,inumber));
            }

            foreach(PersonalInformation personal in list){
            Console.WriteLine(personal);
            }
        }
    }
}




