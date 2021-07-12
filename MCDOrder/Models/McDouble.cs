using System;
using System.Collections.Generic;
using System.Text;
using MCDOrder.BusinessModel;

namespace MCDOrder.Models {
  class McDouble : IMenu{
    private string _menuName = "Mc Double Burger";
    private IIngredients _ingredients;
    internal McDouble(IIngredients ingredients) {
      _ingredients = ingredients;
    }
    string IMenu.MenuName() {
      return _menuName;
    }
    internal void CookMcDouble() {
      _ingredients.Bread();
      _ingredients.Cheese();
      _ingredients.Lettuce();
      _ingredients.Meat();
      _ingredients.Meat();
      _ingredients.Cheese();
      _ingredients.Lettuce();
      _ingredients.Onion();
      _ingredients.Bread();
      Status();
    }
    internal void Status() {
      Console.WriteLine(_menuName);
    }
  }
}
