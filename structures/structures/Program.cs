using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace structures
{
    internal class Program
    {
        struct pokemon
        {
            public int id;
            public string name;
            public int level;

        }
        struct student
        {
            public string name;
            public int age;
            public int grade;
            public gender gender;
            public decimal gpa;

        }
        struct holidays
        {
            public string name;
            public day day;
            
        }
        enum gender {male,female};
        enum day {mon,tues,wed,thurs,fri,sat,sun};-
        static void Main(string[] args)
        {
            pokemon pikachu = new pokemon();
            pikachu.name = "pikachu";
            pikachu.level = 1;
            pikachu.id = 1;
            student me = new student();
            me.name = "jackson";
            me.age = 15;
            me.grade = 10;
            me.gender = gender.male;
            me.gpa = 3;
            holidays mlk = new holidays();
            mlk.day = day.mon;
            mlk.name = "mlk day";
        }
    }
}
