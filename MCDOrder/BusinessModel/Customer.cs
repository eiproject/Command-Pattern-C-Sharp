using System;
using System.Collections.Generic;
using System.Text;
using MCDOrder.Models;

namespace MCDOrder.BusinessModel {
  class Customer : ICustomer {
    private List<IMenu> _orderList = new List<IMenu>();
    private string _customerName;

    internal Customer(string name) {
      _customerName = name;
    }
    void ICustomer.CreateOrder(IMenu menu, int numberOrders) {
      for (int i = 0; i < numberOrders; i++) {
        menu.CustomerName(_customerName);
        _orderList.Add(menu);
      }
    }
    List<IMenu> ICustomer.OrderList() {
      return _orderList;
    }
  }
}
