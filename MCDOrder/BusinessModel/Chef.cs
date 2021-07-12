using MCDOrder.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MCDOrder.BusinessModel {
  class Chef : IChef {
    private List<ICookMenu> _order =  new List<ICookMenu>();
    void IChef.Cooking(List<ICookMenu> menus) {
      for (int i = 0; i < menus.Count; i ++) {
        menus[i].Excecute();
      }
    }

    List<ICookMenu> IChef.ReadOrder(List<IMenu> orders) {
      for (int i = 0; i < orders.Count; i++) {
        if (orders[i].MenuName() == "Big Mac Burger") {
          _order.Add(new MakeBigMac((BigMac)orders[i]));
        }
        else if (orders[i].MenuName() == "Cheese Burger") {
          _order.Add(new MakeCheeseBurger((CheeseBurger)orders[i]));
        }
        else if (orders[i].MenuName() == "Chicken Burger") {
          _order.Add(new MakeChickenBurger((ChickenBurger)orders[i]));
        }
        else if (orders[i].MenuName() == "Mc Double Burger") {
          _order.Add(new MakeMcDouble((McDouble)orders[i]));
        }
        else {

        }
      }

      return _order;
    }
  }
}
