using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace ConsoleApp2.phase1.ConsoleApp2.phase1
{
    internal class teacherBase
    {
        public List<teacherinfo> teachers { get; set; }
        public void Addteacher(teacherinfo t, StreamWriter sw)
        {



            teachers.Add(t);
            sw.WriteLine(t.Id + "," + t.TName + "," + t.Class + "," + t.Section);



        }
        public void DeleteTeacher(int id, string path)
        {
            bool status= false;
            List<string> final = new List<string>();
            StreamReader sr = new StreamReader(path);
            while (sr.Peek() >= 0)
            {
                string line = sr.ReadLine();
                List<string> data = line.Split(",", 4).ToList();
                string ss;
                if (data[0] == id.ToString())
                {
                    Console.WriteLine($" Teacher with id : {id} deleted");
                    status = true;
                }
                else
                {
                    ss = string.Join(",", data);
                    final.Add(ss);
                }
            }

            if (status==false)
                Console.WriteLine($"no teacher with id: {id}");

            sr.Close();

            string s3 = string.Join("\n", final);
            StreamWriter sw3 = new StreamWriter(path);
            sw3.WriteLine(s3);
            sw3.Close();
        }
        public void GetAllteachers(StreamReader sr)
        {
            while (sr.Peek() >= 0)
            {
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
        }
        public void SearchById(int id, string path)
        {
            StreamReader sr = new StreamReader(path);
            while (sr.Peek() >= 0)
            {
                string line = sr.ReadLine();
                List<string> data = line.Split(",", 4).ToList();
                if (data[0] == id.ToString())
                {
                    Console.WriteLine(line);
                    break;
                }
                
            }
            if (sr.Peek() <= 0)
                Console.WriteLine($"no teacher with id: {id}");
        }
        public void updateteacher(teacherinfo t, string path)
        {
            List<string> final = new List<string>();
            StreamReader sr = new StreamReader(path);
            while (sr.Peek() >= 0)
            {
                string line = sr.ReadLine();
                List<string> data = line.Split(",", 4).ToList();
                string ss;
                if (data[0] == t.Id.ToString())
                {
                    data[1] = t.TName;
                    data[2] = t.Class.ToString();
                    data[3] = t.Section;
                    ss = string.Join(",", data);
                    final.Add(ss);
                }
                else
                {
                    ss = string.Join(",", data);
                    final.Add(ss);
                }
            }
            sr.Close();
            string s3 = string.Join("\n", final);
            StreamWriter sw3 = new StreamWriter(path);
            sw3.WriteLine(s3);
            sw3.Close();
        }
    }
}