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
      IWaitress Waitress1 = new Waitress();
      Waitress1.CreateOrder(BigMacBurger, 1);
      Waitress1.CreateOrder(CheeseBurger, 3);

      // Order up
      Waitress1.OrderUp();

      IChef Chef1 = new Chef();
      List<ICookMenu> CookingMenu = Chef1.ReadOrder(Waitress1.TakeOrderList());
      Chef1.Cooking(CookingMenu);
    }
  }
}
