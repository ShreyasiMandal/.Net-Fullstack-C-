using System;

namespace Q2Practice;

public class InvalidFlavourException :Exception
{
   public InvalidFlavourException():base("Flavour not Available! Please Select the Available Flavour")
   {}
   public InvalidFlavourException(String message):base(message){}

}
