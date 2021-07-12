using System;
using System.Collections.Generic;
using System.Text;
using MCDOrder.BusinessModel;

namespace MCDOrder.Models {
  class ChickenBurger : IMenu{
    private string _menuName = "Chicken Burger";
    private string _customerName;

    private IIngredients _ingredients;
    internal ChickenBurger(IIngredients ingredients) {
      _ingredients = ingredients;
    }
    string IMenu.MenuName() {
      return _menuName;
    }
    void IMenu.CustomerName(string customerName) {
      _customerName = customerName;
    }
    internal void CookChickenBurger() {
      _ingredients.Bread();
      _ingredients.Lettuce();
      _ingredients.ChickenMeat();
      _ingredients.Cheese();
      _ingredients.ChickenMeat();
      _ingredients.Cheese();
      _ingredients.Lettuce();
      _ingredients.Bread();
      Status();
    }
    internal void Status() {
      Console.WriteLine(_customerName + " : " + _menuName + " Done");
    }
  }
}
