
namespace DynamicBinding
{
    class Program
    {
        static void Main(string[] args)
        {
            object obj = "Mosh";
            //obj.GetHashCode();
            //alternative to dynamic is reflection, dynamic is the simplified alternative used in place of reflection
            var methodinfo = obj.GetType().GetMethod("GetHashCode");
            methodinfo.Invoke(null, null);

            //handles it all in run time
            dynamic excelObject = "mosh";
            excelObject.Optimize();

            dynamic name = "Mosh";
            name = 10;

            //When using dynamics more testing should be done since errors occur at runtime rather than compile time

            dynamic a = 10;
            dynamic b = 5;
            //when using dynamic variables in an expression the expressions variable will be dynamic as well
            var c = a + b;

            //if the runtime type is implicitly convertible to the type storing it then it does not need to be cast
            int i = 5;
            dynamic d = i;
            long l = d;
        }
    }
}
