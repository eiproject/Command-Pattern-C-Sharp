﻿using System;
using System.Collections.Generic;
using System.Text;
using MCDOrder.Models;

namespace MCDOrder.BusinessModel {
  interface IWaitress {
    List<IMenu> OrderUp();
    void PickUpOrder(List<IMenu> orders);
  }
}
