using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimApi1.DataContext;
using SimApi1.Models;

namespace SimApi1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Comp_Mast_Controller : ControllerBase
    {
        private readonly SimApi1DbContext dbcontext;
        public Comp_Mast_Controller(SimApi1DbContext simapi1dbcontext)
        {
            dbcontext = simapi1dbcontext;
        }

        [HttpGet]
        public IActionResult GetAllComponents()
        {
            return Ok(dbcontext.Comp_Mast.ToList());
        }

        [HttpPost]
        //[FromBody, comp_mast]
        public IActionResult NewComponent(Component_Master comp_mast)
        {

        }
    }
}
