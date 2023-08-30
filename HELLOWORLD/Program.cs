using h = System.Console;

namespace HELLOWORLD
{
    internal class Program
    {
        public void disp()
        {
            h.WriteLine("HELLO WORLD");
        }
        static void Main(string[] args)
        {
            h.WriteLine("GOOD MORNING");
            Program obj=new Program();
            obj.disp();
        }
    }
}
