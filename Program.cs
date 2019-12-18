using System;
using System.Linq;

namespace aliBaba_c__Course
{


    

    
    class person {

        public person(int id, int age, String fName, String lName) {
            this.id = id;
            this.age = age;
            this.fName = fName;
            this.lName = lName;
        }
        public int id;
        public int age;
        public String fName;
        public String lName;
    }

    class grade {
        public int pId;

        public int java;
        public int cs;
        public int go;

        public grade(int pId, int java, int cs, int go) {
            this.pId = pId;
            this.java = java;
            this.cs = cs;
            this.go = go;
        }
    }
    interface car {
        
        int getDoorNum();
        int getSpeed();
        int getEnginePower();
        int getWindowNum();
    }

    class bmw : car {
        
        private int speed;
        private int doorNum;
        private int enginPower;
        private int windowNum;


        public bmw(int speed, int doorNum, int enginPower, int windowNum) {
            this.windowNum = windowNum;
            this.doorNum = doorNum;
            this.speed = speed;
            this.enginPower = enginPower;

        }
        public int getSpeed() {
            return speed;
        }

        public int getDoorNum() {
            return doorNum;
        }

        public int getEnginePower() {
            return enginPower;
        }

        public int getWindowNum() {
            return windowNum;
        }
        

    }

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

            person p1 = new person(1,20,"mohamad", "fatemi");
            person p2 = new person(2,21,"mohamadHasan", "Taghadosi");
            person p3 = new person(3, 20, "zahra", "tehrani");
            grade g1 = new grade(1,18,20,20);
            grade g2 = new grade(2,19,17,20);
            grade g3 = new grade(3,19,18,12);
            person[] persons = {p1,p2,p3};
            grade[] grades = {g1,g2,g3};
            //var joinRes = (from person in persons join grade in grades on person.id equals grade.pId select new {name = person.fName,  csGrade = grade.cs, goGrade = grade.go, javaGrade = grade.java});
            
            var joinRes = (from person in persons join grade in grades on person.id equals grade.pId let avg = (grade.java + grade.go + grade.cs)/3 select avg);
            
            // foreach(var g in joinRes) {
            //     Console.WriteLine(g);
            // }
            foreach(var g in joinRes) {
                Console.WriteLine(g.name + " " + ((g.csGrade + g.goGrade + g.javaGrade) /3));
            }
            // int[] arr = {10,2,8,7343,345,45,23,6,22,2,778,121};
            // //var list  = (from n in arr where n < 400 orderby n descending select n).ToList();
            // var list = (from n in arr where n == 2 select n).Count();

            // Console.WriteLine(list);
        //      foreach( int g in list ) 
        // { 
              
        //     // Display sorted list 
        //     Console.WriteLine(g); 
              
        // } 
            // bmw b1 = new bmw(100,2,200,4);
            // car c1 = new bmw(120, 4, 170, 6);
            // Console.WriteLine("speed = " + c1.getSpeed());
            // IEnumerable<int> listIE = new List<int>();
            // int input;
            // DateTime DateInSystemDateTime = DateTime.UtcNow.Date;
            // DateInSystemDateTime.toShamsi();
            // input = Convert.ToInt32(Console.ReadLine());
            // input.print();

            // "tgh".translate();
            // Console.WriteLine();
            // writer.print(input);

        }
    }
}
