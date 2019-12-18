using System;

namespace aliBaba_c__Course
{


    static class writer {
        
        public static void translate(this string word) {
            for(int i = 0; i < word.Length; i++) {
                if(word[i] == 't') {
                    Console.Write("ت");
                }
                if(word[i] == 'g') {
                    Console.Write("ق");
                }
                if(word[i] == 'h') {
                    Console.Write("د");
                }

            }
        }
        public static void toShamsi(this DateTime DateInSystemDateTime) {
        System.Globalization.PersianCalendar persianCalandar = new System.Globalization.PersianCalendar();
        int year = persianCalandar.GetYear(DateInSystemDateTime);
        int month = persianCalandar.GetMonth(DateInSystemDateTime);
        int day = persianCalandar.GetDayOfMonth(DateInSystemDateTime);
        Console.WriteLine(year + " " + month + " " + day);
     }

        public static void print(this int num) {
                
                Console.WriteLine("Commas:{0:n1}",num);
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            DateTime DateInSystemDateTime = DateTime.UtcNow.Date;
            DateInSystemDateTime.toShamsi();
            input = Convert.ToInt32(Console.ReadLine());
            input.print();

            "tgh".translate();
            Console.WriteLine();
            // writer.print(input);

        }
    }
}
