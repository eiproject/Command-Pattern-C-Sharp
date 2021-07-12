using System;
using System.Collections.Generic;
using System.Text;
using MCDOrder.Models;

namespace MCDOrder.BusinessModel {
  interface IChef {
    List<ICookMenu> ReadOrder(List<IMenu> menus);  
    void Cooking(List<ICookMenu> menu);
  }
}
