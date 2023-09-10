using System.Collections.Generic;

namespace PierresBakery.Models
{
public class Bakery
{
    public static Dictionary<string, int> bakeryOrder = new Dictionary<string, int>()
    {
        {"Bread", 0},
        {"Pastry", 0}
    };
  
    public void Order(int userBread, int userPastry)
    {
        bakeryOrder["Bread"] = userBread;
        bakeryOrder["Pastry"] = userPastry;
    }
}
}