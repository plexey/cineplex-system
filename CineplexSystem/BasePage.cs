using CineplexSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;

namespace CineplexSystem
{
    public class BasePage : System.Web.UI.Page
    {
        public static int currentMovieID;
        public static CPIStudent_dbEntities dbeCineplex = new CPIStudent_dbEntities();
        public static List<Movie> movies;
        public static List<ShoppingCartData> shoppingCart = new List<ShoppingCartData>();
        private void Page_PreRender(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.Title) || this.Title.Equals("Untitled Page",
            StringComparison.CurrentCultureIgnoreCase))
            {
                throw new Exception(
                "Page title cannot be \"Untitled Page\" or an empty string.");
            }
        }
        public BasePage()
        {
            this.PreRender += Page_PreRender;
        }

        // refresh the cart item count on the mater page
        protected void UpdateCartItemDisplay(int theQuantity)
        {
            Label lblQuantity;
            lblQuantity = Master_Pages.Main.MasterQuantity;
            lblQuantity.Text = theQuantity.ToString();
            lblQuantity.ToolTip = theQuantity.ToString() + " items are in your cart";
        }
    }
}
