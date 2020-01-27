using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;


namespace stream_writer
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw=new StreamWriter("input.text");
            sw.WriteLine("Some people have curly brown hair till pointed black");
            sw.Close();
            sw.WriteLine("The quick brown fox jump over the lazy dog");
            sw.Close();
            sw.WriteLine("The should be a logical minded");
            sw.Close();
        }
        
    }
}