using System;
using System.Collections.Generic;
using System.Text;
using MCDOrder.Models;
using MCDOrder.BusinessModel;

namespace MCDOrder {
  class Run {
    internal Run() {
      // Ingredient 
      IIngredients ingredient = new Ingredients();
      
      // Order menu
      IMenu BigMacBurger = new BigMac(ingredient);
      IMenu CheeseBurger = new CheeseBurger(ingredient);
      IMenu ChickenBurger = new ChickenBurger(ingredient);
      IMenu McDoubleBurger = new McDouble(ingredient);

      // Write order
      ICustomer Customer1 = new Customer("Joko");
      Customer1.CreateOrder(BigMacBurger, 1);
      Customer1.CreateOrder(CheeseBurger, 3);

      ICustomer Customer2 = new Customer("Bambang");
      Customer2.CreateOrder(ChickenBurger, 2);

      ICustomer Customer3 = new Customer("Syaiful");
      Customer3.CreateOrder(McDoubleBurger, 4);


      // Waitress take
      IWaitress Waitress1 = new Waitress();
      Waitress1.PickUpOrder(Customer1.OrderList());
      Waitress1.PickUpOrder(Customer2.OrderList());
      Waitress1.PickUpOrder(Customer3.OrderList());
      
      List<IMenu> Orders  = Waitress1.OrderUp();

      // Chef make the order
      IChef Chef1 = new Chef();
      List<ICookMenu> CookingMenu = Chef1.ReadOrder(Orders);
      Chef1.Cooking(CookingMenu);
    }
  }
}
