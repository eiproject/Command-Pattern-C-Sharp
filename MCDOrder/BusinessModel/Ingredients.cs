using System;
using System.Collections.Generic;
using System.Text;

namespace MCDOrder.BusinessModel {
  class Ingredients : IIngredients {
    internal Ingredients() {
      Console.WriteLine("Preparing Ingredients.");
    }
    void IIngredients.Bread() {}
    void IIngredients.Meat() {}
    void IIngredients.Cheese() {}
    void IIngredients.Lettuce() {}
    void IIngredients.Mayonaise() {}
    void IIngredients.Onion() {}
    void IIngredients.Sauce() {}
    void IIngredients.Tomato() {}
    void IIngredients.ChickenMeat() {}
  }
}
