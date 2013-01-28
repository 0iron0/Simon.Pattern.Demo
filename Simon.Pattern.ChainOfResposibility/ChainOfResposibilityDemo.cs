using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simon.Pattern.ChainOfResposibility
{
    public class ChainOfResposibilityDemo
    {
        public static void Run()
        {
            Director d = new Director();
            VicePresident v = new VicePresident();
            President p = new President();

            d.SetApprover(v);
            v.SetApprover(p);

            Purchase purchase = new Purchase(2034, 350, "Supplies"); 
            d.ProcessRequest(purchase); 
            purchase = new Purchase(2035, 8888, "Project X"); 
            d.ProcessRequest(purchase); 
            purchase = new Purchase(2036, 12000, "Project Y"); 
            d.ProcessRequest(purchase);
        }
    }
}
