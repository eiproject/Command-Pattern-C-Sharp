using System;
using System.Collections.Generic;
using System.Text;
using MCDOrder.Models;

namespace MCDOrder.BusinessModel {
  class MakeBigMac : ICookMenu {
    private BigMac _bigMac;
    internal MakeBigMac(BigMac bigMac) {
      _bigMac = bigMac;
    }
    void ICookMenu.Excecute() {
      _bigMac.CookBigMac();
    }
  }
}
