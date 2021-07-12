using System;
using System.Collections.Generic;
using System.Text;
using MCDOrder.BusinessModel;

namespace MCDOrder.Models {
  class CheeseBurger : IMenu{
    private string _menuName = "Cheese Burger";
    private string _customerName;

    private IIngredients _ingredients;
    internal CheeseBurger(IIngredients ingredients) {
      _ingredients = ingredients;
    }
    string IMenu.MenuName() {
      return _menuName;
    }
    void IMenu.CustomerName(string customerName) {
      _customerName = customerName;
    }
    internal void CookCheeseBurger() {
      _ingredients.Bread();
      _ingredients.Lettuce();
      _ingredients.Meat();
      _ingredients.Cheese();
      _ingredients.Meat();
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
