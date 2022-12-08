namespace program;
using System.Reflection;

class Program
{
    public static void AddToXML(string data)
    {
        File.AppendAllText("/Users/marmelad/RiderProjects/lab07/program/Asswmbly.xml", data + "\n");
    }
    
    static void Main()
    {
        AddToXML("\n");
        AddToXML("<lab07>");
        AddToXML("\n");
        var path = @"/Users/marmelad/RiderProjects/lab07/Animal/bin/Debug/net6.0/Animal.dll";
        Assembly assembly = Assembly.LoadFrom(path);
        AddToXML($"<comment>{assembly.FullName}<comment/>");
        foreach (Type k in assembly.GetTypes())
        {
            if (k.IsClass)
            {
                Console.WriteLine("type:\n");
                AddToXML($"\n<class>{k.FullName} : {k.BaseType}<class/>");
                AddToXML($"<comment>is abstract:{k.IsAbstract}<comment/>");
                foreach (Attribute y in k.GetCustomAttributes())
                {
                    if (y.ToString() == "Animal.CommentAttribute")
                    {
                        AddToXML($"<comment>{y}<comment/>");
                    }
                }
                AddToXML("<comment>methods:<comment/>\n");
                foreach (MethodInfo z in k.GetMethods())
                {
                    AddToXML($"<method>{z.Name}<method/>");
                    // Console.WriteLine(z.ReturnType);
                    // Console.WriteLine(z.MemberType);
                }
            }
        }
        AddToXML("<lab07/>");
    }
}