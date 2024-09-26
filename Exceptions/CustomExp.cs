using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class CustomExp
    {
        static void Main(string[] args)
        {
            try
            {
                throw new UserNotFound("hello");
            }
            catch (UserNotFound e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e) 
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("This is finally");
            }
        }
    }
}
