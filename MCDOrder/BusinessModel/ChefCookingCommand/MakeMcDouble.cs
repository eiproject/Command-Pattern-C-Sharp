using System;
using System.Collections.Generic;
using System.Text;
using MCDOrder.Models;

namespace MCDOrder.BusinessModel {
  class MakeMcDouble : ICookMenu {
    private McDouble _mcDouble;
    internal MakeMcDouble(McDouble mcDouble) {
      _mcDouble = mcDouble;
    }
    void ICookMenu.Excecute() {
      _mcDouble.CookMcDouble();
    }
  }
}
