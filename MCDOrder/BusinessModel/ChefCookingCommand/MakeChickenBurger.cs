using System;
using System.Collections.Generic;
using System.Text;
using MCDOrder.Models;

namespace MCDOrder.BusinessModel {
  class MakeChickenBurger : ICookMenu {
    private ChickenBurger _chickenBurger;
    internal MakeChickenBurger(ChickenBurger chickenBurger) {
      _chickenBurger = chickenBurger;
    }
    void ICookMenu.Excecute() {
      _chickenBurger.CookChickenBurger();
    }
  }
}
