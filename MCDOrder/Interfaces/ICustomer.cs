using System;
using System.Collections.Generic;
using System.Text;
using MCDOrder.Models;

namespace MCDOrder.BusinessModel {
  interface ICustomer
    {
    void CreateOrder(IMenu menu, int numbers);
    List<IMenu> OrderList();
  }
}
