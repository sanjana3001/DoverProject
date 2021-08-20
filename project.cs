using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace ConsoleApp2.phase1
{
    namespace ConsoleApp2.phase1
    {
        class teacherinfo : teacherinfoBase
        {
          public teacherinfo()
            {

            }
            public teacherinfo(int id, string name, int Class, string section)
            {
                this.Id = id;
                this.TName = name;
                this.Class = Class;
                this.Section = section;  
            }
        }
        class teacher : teacherBase
        {
            public teacher()
            {
                teachers = new List<teacherinfo>();

            }
        }
        class project
    {
        static void Main(string[] args)
        {
                    
                teacher dis = new teacher();
                string path = @"C:\training\teacherinfo.txt";

                Console.WriteLine("input the choice\n 1 : Get All Teachers \n 2: Add Teacher \n" +
                    " 3: Update Teacher\n 4: delete teacher info \n 5: Search teacher \n 6: exit");
                        int c = int.Parse(Console.ReadLine());
                        switch (c)
                        {
                            case 1:
                                StreamReader sr = new StreamReader(path);
                                sr = new StreamReader(path);
                                dis.GetAllteachers(sr);
                                sr.Close();
                                break;
                            case 2:
                                //add teacher
                                StreamWriter sw = new StreamWriter(path, append: true);
                                teacherinfo tr1 = new teacherinfo();
                                Console.WriteLine(" enter ID: ");
                                int Id = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine(" enter class:");
                                int Class = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("enter section:");
                                string Sec = Console.ReadLine();
                                Console.WriteLine(" enter name: ");
                                string TName = Console.ReadLine();
                                tr1 = new teacherinfo(Id, TName, Class, Sec);
                                dis.Addteacher(tr1, sw);
                                sw.Close();
                                break;
                            case 3:
                                teacherinfo tru = new teacherinfo();
                                Console.WriteLine(" enter ID: ");
                                int Idu = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine(" enter class:");
                                int Classu = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("enter section:");
                                string Secu = Console.ReadLine();
                                Console.WriteLine(" enter name: ");
                                string TNameu = Console.ReadLine();
                                tru = new teacherinfo(Idu, TNameu, Classu, Secu);
                                dis.updateteacher(tru, path);
                                break;
                            case 4:
                                Console.WriteLine("Enter the ID: ");
                                int id = Convert.ToInt32(Console.ReadLine());
                                dis.DeleteTeacher(id, path);
                                 break;
                            case 5:
                                Console.WriteLine(" enter teacher id: ");
                                int tid = Convert.ToInt32(Console.ReadLine());
                                dis.SearchById(tid, path);
                                break;
                            case 6:
                                break;


                        }
        }
        }
    }
}

