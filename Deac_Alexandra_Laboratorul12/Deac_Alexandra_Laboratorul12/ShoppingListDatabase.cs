using Deac_Alexandra_Laboratorul12.Data;
using Deac_Alexandra_Laboratorul12.Models;
using System;
using System.Collections;
using System.Threading.Tasks;

namespace Deac_Alexandra_Laboratorul12
{
    public class ShoppingListDatabase
    {
        private RestService restService;

        public ShoppingListDatabase(RestService restService)
        {
            this.restService = restService;
        }

        internal Task SaveShopListAsync(ShopList slist)
        {
            throw new NotImplementedException();
        }

        internal Task DeleteShopListAsync(ShopList slist)
        {
            throw new NotImplementedException();
        }

        internal Task<IEnumerable> GetShopListsAsync()
        {
            throw new NotImplementedException();
        }
    }
}