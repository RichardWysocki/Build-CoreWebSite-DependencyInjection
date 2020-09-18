using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Business.Shared.CarExample;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Customer.ASPNETCore.UI.Pages
{
    public class CarListViewModel : PageModel
    {
        public CarListViewModel()
        {
            var carDataAccess = new CarDataAccess("US");
            Cars = new CarRepository(carDataAccess).GetCars();
        }

        public List<Car> Cars { get; set; }

        public void OnGet()
        {
        }
    }
}
