using System.Collections.Generic;
using System.Threading.Tasks;
using Deac_Alexandra_Laboratorul12.Models;

namespace Deac_Alexandra_Laboratorul12.Data
{
    public interface IRestService
    {
        Task<List<ShopList>> RefreshDataAsync();
        Task SaveShopListAsync(ShopList item, bool isNewItem);
        Task DeleteShopListAsync(int id);
    }
}
