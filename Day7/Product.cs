using System;

namespace AccessModifier;

public class Product
{
   #region Properties
   //Auto Implicit Properties
   public int ProdID { get; set; }

  public string Name{ get; set; }

  protected string Ingridents{get; set;} //

  private int MFcost;  //{get;set;}//dont make it properties by get set because you dont want to expose so make it as a variable

  internal string BatchNo{get; set;}

  protected internal string LotNo {get;set;}  
  //Within the same project like within the same application only 
  //cant be accesesd in Other project  even if it is a child class


   #endregion
}
