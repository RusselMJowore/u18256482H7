using Homework_7.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;


namespace Homework_7.Controllers
{
    public class ShopController : Controller
    {
        SqlConnection redConnection = new SqlConnection("Data Source=INFGY-09\\MSSQL14;Initial Catalog=Reddragon;Integrated Security=True");
        // GET: Shop
        public static List<ShopItemViewModel> comics = new List<ShopItemViewModel>();
        public int c;
        public ActionResult Index(string sort)
        {
            ShopItemViewModel newItem = new ShopItemViewModel();
            switch (sort)
            {
                case "Sort by Name":
                    comics = orderbyname(comics);
                    return View(comics);

                case "Sort by Price":
                    comics = orderbyprice(comics);
                    return View(comics);

                case "Sort by Quantity Available ":
                    comics = orderbyQuantity(comics);
                    return View(comics);

               // case "How many items are in the list?":
                //     c = comics.Count;
                 //   ViewBag.Message = c.ToString();
               //     return View();
                default:
                    return View(comics);

            }
        }
       

        public ActionResult AddItem()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddItem(string iName, string iDesciption, double iPrice, int iQuantityAvailable)
        {

            ShopItemViewModel newItem = new ShopItemViewModel(iName, iDesciption, iPrice, iQuantityAvailable,comics);
            comics.Add(newItem);


            return View("Index",comics);
        }
      
      
        private List<ShopItemViewModel> orderbyname (List<ShopItemViewModel> comics)
        {
            return comics.OrderBy(zz => zz.Name).ToList();

        }
        private List<ShopItemViewModel> orderbyprice(List<ShopItemViewModel> comics)
        {
            return comics.OrderBy(zz => zz.Price).ToList();

        }
        private List<ShopItemViewModel> orderbyQuantity(List<ShopItemViewModel> comics)
        {
            return comics.OrderBy(zz => zz.QuantityAvailable).ToList();

        }


        public ActionResult Part2()
        {
            return View();
        }  

        [HttpPost]
        public ActionResult Part2(string Name, string Desciption, double Price, int QuantityAvailable)
        {
            try
            {
                SqlCommand addcomic = new SqlCommand("Insert into ShopItem Values('" + Name + "','" + Desciption + "','" + Price + "','" + QuantityAvailable + "')", redConnection);
                redConnection.Open();
                addcomic.ExecuteNonQuery();

            }
            catch (Exception Error)
            {
                ViewBag.Message = "Error: " + Error.Message;
            }
            finally
            {
                redConnection.Close();
            }
                return View();
        }
        
    }
}
