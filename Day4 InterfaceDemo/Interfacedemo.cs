using System;

namespace InterfaceDemo;



    interface IAdd
    {
      int AddMe(int num1,int num2)  ;
    }
      //no body allowed only curly baces is not allowed also
      //it indicates empty body

       interface ISub
    {
      int SubMe(int num1,int num2)  ;
    }

     interface IProd
    {
      int ProdMe(int num1,int num2)  ;
    }

     interface IDiv
    {
      float DivMe(int num1,int num2)  ;
    }

    interface IAddSub : IAdd, ISub 
    //Interface supports multiple inheritance
    {
        
    }
    interface IAddProdDiv: IAdd,IProd,IDiv{}
    interface IAll: IAddProdDiv,ISub{} //one interface can implement another interface also
    //Multilevel inheritance


    //for every interface we need different files
      
//Multilevel 


    

