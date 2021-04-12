using Shop1.Data.Interface;
using Shop1.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop1.Data.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category {CategoryName = "Electromobile", Desc = "Sovremenni vid transporta"},
                    new Category {CategoryName = "Klassic Automobile", Desc = "Mashini s dvigitel vnutrennego egoraniya"},
                };
            }
        }
    }
}
