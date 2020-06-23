using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions
{
    public class CourseException : Exception
    {
        public CourseException():base()
        {
                
        }
        public CourseException(String message):base(message)
        {
            
        }
    }
}
