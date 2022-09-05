using System;
using System.Collections.Generic;


namespace OOPClassesIntro
{
    public class Product //The term 'class' here refers to what is known as a class keyword.
    {
       public int Id { get; set; }
       public string Name { get; set; }
       public double Price { get; set; }
       public int CategoryID { get; set; }
       public bool IsOnSale { get; set; }

    }
}
