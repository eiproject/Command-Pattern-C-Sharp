using System;
using System.Collections.Generic;
using System.Text;
using MCDOrder.Models;

namespace MCDOrder.BusinessModel {
  class Waitress : IWaitress {
    private List<IMenu> _orderList = new List<IMenu>();
    internal Waitress() {
    }
    void IWaitress.PickUpOrder(List<IMenu> orders) {
      for (int i = 0; i< orders.Count; i++) {
        _orderList.Add(orders[i]);
      }
    }
    List<IMenu> IWaitress.OrderUp() {
      return _orderList;
    }
  }
}
