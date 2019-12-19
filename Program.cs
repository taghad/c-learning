using System;
using System.Linq;

namespace aliBaba_c__Course
{


   

    
    class person {

        public person(int id, String address, String fName, String lName) {
            this.id = id;
            this.address = address;
            this.fName = fName;
            this.lName = lName;
        }
        public int id;
        public String address;
        public String fName;
        public String lName;
    }


    class salary {
        public int id;
        public int daySalary;
        public int bahmanSalary;
        public int esfandSalary;

        public salary(int id, int daySalary, int bahmanSalary, int esfandSalary) {
            this.id = id;
            this.daySalary = daySalary;
            this.bahmanSalary = bahmanSalary;
            this.esfandSalary = esfandSalary;
        }

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

            // person p1 = new person(1,20,"mohamad", "fatemi");
            // person p2 = new person(2,21,"mohamadHasan", "Taghadosi");
            // person p3 = new person(3, 20, "zahra", "tehrani");
            // grade g1 = new grade(1,18,20,20);
            // grade g2 = new grade(2,19,17,20);
            // grade g3 = new grade(3,19,18,12);
            // person[] persons = {p1,p2,p3};
            // grade[] grades = {g1,g2,g3};
            // //var joinRes = (from person in persons join grade in grades on person.id equals grade.pId select new {name = person.fName,  csGrade = grade.cs, goGrade = grade.go, javaGrade = grade.java});
            
            // var joinRes = (from person in persons join grade in grades on person.id equals grade.pId let avg = (grade.java + grade.go + grade.cs)/3 select avg);
            
            // // foreach(var g in joinRes) {
            // //     Console.WriteLine(g);
            // // }
            // foreach(var g in joinRes) {
            //     Console.WriteLine(g.name + " " + ((g.csGrade + g.goGrade + g.javaGrade) /3));
            
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

            // int[] numbers = {10,45,677,4,232,2,788,2233,7687,8,54,3454};

            // // var check = numbers.Where(a => a == 2).Any();
            // // var check = numbers.Any(a => a == 2);
            // var firstOrDefaultSelect = numbers.Where(a => a == 677).FirstOrDefault();
            // Console.WriteLine(firstOrDefaultSelect);
            // var firstSelect = numbers.Where(a => a == 677).First();
            // Console.WriteLine(firstSelect);
            // var singleSelect = numbers.Where(a => a == 677).Single();
            // Console.WriteLine(singleSelect);

            // var singleOrDefaultSelect = numbers.Where(a => a == 677).SingleOrDefault();
            // Console.WriteLine(singleOrDefaultSelect);

            // String[] names = {"sara","ghasemi","taghad","eldaa","shayan","rahim"};
            // //var haveCharI = names.Where(a => a.ToLower.Contains('i'));

            // var startWithS = names.Where(a => a.ToLower().StartsWith('s'));

            // foreach(String i in startWithS) {
            //     Console.WriteLine(i);
            // }

            person p1 = new person(1,"tehrn","mohamad", "fatemi");
            person p2 = new person(2,"ahvaz","mohamadHasan", "Taghadosi");
            person p3 = new person(3, "qom", "zahra", "tehrani");
            person[] persons = {p1,p2,p3};

            salary s1 = new salary(1,100,200,300);
            salary s2 = new salary(2,1000,2000,3000);
            salary s3 = new salary(3,10000,20000,30000);
            salary[] salaries = {s1,s2,s3};

            var pooldar = salaries.Max(a => a.esfandSalary + a.bahmanSalary + a.daySalary);
            var idPooldar = salaries.Where(a => a.daySalary + a.esfandSalary + a.bahmanSalary == pooldar).SingleOrDefault();

            var richest = persons.Where(a => a.id == idPooldar.id);

            foreach(person i in richest) {
                Console.WriteLine(i.fName + " " + i.lName);
            }


        }
    }
}
