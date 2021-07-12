using System;
using System.Collections.Generic;
using System.Text;
using MCDOrder.Models;

namespace MCDOrder.BusinessModel {
  class Waitress : IWaitress {
    private List<IMenu> _orderList = new List<IMenu>();
    private List<IMenu> _orderUp;
    internal Waitress() {
      Console.WriteLine("Waitress.. ");
    }
    void IWaitress.CreateOrder(IMenu menu, int numberOrders) {
      for (int i = 0; i < numberOrders; i++) {
        _orderList.Add(menu);
      }

      Console.WriteLine("Waitress.. Create order");
    }
    void IWaitress.OrderUp() {
      _orderUp = _orderList;
      Console.WriteLine("Waitress.. Order Up.");
    }
    List<IMenu> IWaitress.TakeOrderList() {
      return _orderUp;
    }
  }
}
