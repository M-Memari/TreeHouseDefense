using System;

namespace TreeHouseDefense
{
    public class OutOfBoundsException : Exception
    {
        public OutOfBoundsException()
        {
            
        }

        public OutOfBoundsException(string message) : base(message)
        {
            
        }
        
    }
}