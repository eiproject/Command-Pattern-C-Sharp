using System;
using System.Collections.Generic;
using System.Text;
using MCDOrder.Models;

namespace MCDOrder.BusinessModel {
  interface IWaitress {
    void CreateOrder(IMenu menu, int numbers);
    void OrderUp();
    List<IMenu> TakeOrderList();
  }
}
