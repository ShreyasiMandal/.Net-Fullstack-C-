using System;

namespace Q2Practice;

public class InvalidQuantityException:Exception

    {
   public InvalidQuantityException(): base("Quantity Must be Greater than zero")
   {}
   public InvalidQuantityException(String message): base(message){}

}
