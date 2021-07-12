using System;
using System.Collections.Generic;
using System.Text;
using MCDOrder.Models;

namespace MCDOrder.BusinessModel {
  class MakeCheeseBurger : ICookMenu {
    private CheeseBurger _cheeseBurger;
    internal MakeCheeseBurger(CheeseBurger bigMac) {
      _cheeseBurger = bigMac;
    }
    void ICookMenu.Excecute() {
      _cheeseBurger.CookCheeseBurger();
    }
  }
}
