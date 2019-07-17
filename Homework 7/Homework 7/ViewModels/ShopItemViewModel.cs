using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homework_7.ViewModels
{
    public class ShopItemViewModel
    {

        private string mName { get; set; }
        private string mDescription { get; set; }
        private double mPrice { get; set; }
        private int mQuantityAvailable { get; set; }
        public List<ShopItemViewModel> Items { get; set; }
        public ShopItemViewModel() { }
        public ShopItemViewModel(string Name, string Description, double Price, int QuantityAvailable, List<ShopItemViewModel> items)
        {
            mName = Name;
            mDescription = Description;
            mPrice = Price;
            mQuantityAvailable = QuantityAvailable;
            Items = items;
        }
        public string Name
        {
            get
            {
                return mName;
            }

            set
            {
                mName = value;
            }
        }

        public string Description
        {
            get
            {
                return mDescription;
            }

            set
            {
                mDescription = value;
            }
        }

        internal static object orderbyname(Func<object, object> p)
        {
            throw new NotImplementedException();
        }

        public double Price
        {
            get
            {
                return mPrice;
            }

            set
            {
                mPrice = value;
            }
        }

        public int QuantityAvailable
        {
            get
            {
                return mQuantityAvailable;
            }

            set
            {
                mQuantityAvailable = value;
            }
        }

    }
}