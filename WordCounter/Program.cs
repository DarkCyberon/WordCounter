using com.sun.tools.javadoc;
using PorterStemmer.Stemmers;
using WordCounter;

class Program
{
    static void Main()
    {
        //TimeMeasurer tm = new TimeMeasurer();
        //tm.Start(5000);
        InputOutput io = new InputOutput();
        io.ConsoleOut(io.ReadFile());
    }
}