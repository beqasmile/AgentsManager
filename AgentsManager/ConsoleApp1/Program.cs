using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime();
            dateTime = DateTime.Now;
            dateTime = DateTime.Today;
            DateTime dateTommorow = dateTime.AddDays(1);
            DateTime dateTime10DaysBefore = dateTime.AddDays(-10);
            DateTime date6HoursBefore = dateTime.AddHours(-6);
            DateTime date6Hours23MinutesBefore = dateTime.AddHours(-6).AddMinutes(-23);


            Color a = new Color();
           
            Color _color = System.Drawing.ColorTranslator.FromHtml("427983");



            string  fileNameRead = @"C:\dev\16day\06_CS_C_Object_OrientedOutput.pptx";
            string fileNameWrite = @"C:\dev\16day\06_CS_C_Object_OrientedSaved.pptx";

            



            FileStream fs = File.OpenRead(fileNameRead);

            FileStream fsOut = File.OpenWrite(fileNameWrite);
            

            byte[] buf = new byte[1024];
            int c;

            c = fs.Read(buf, 0, buf.Length);
            while (c > 0)
            {
                for (int i=0; i< buf.Length; i++)
                {
                    buf[i] = (byte)(buf[i] - 3);
                }
                fsOut.Write(buf, 0, c);
                //Console.WriteLine(Encoding.UTF8.GetString(buf, 0, c));
                c = fs.Read(buf, 0, buf.Length);
            }


            fsOut.Close();
            Console.ReadKey();

        }
    }
}
