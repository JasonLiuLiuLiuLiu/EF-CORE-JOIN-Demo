using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF_Core_Join.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EF_Core_Join.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly HouseContext _context;
        public ValuesController(HouseContext context)
        {
            this._context = context;
        }

        // GET api/values
        [HttpGet]
        public List<PetsDetails> Get()
        {
            return _context.Pets.Join(_context.Persons,pet=>pet.Owner,per=>per.Id,(pet,per)=>new PetsDetails
            {
                PetName = pet.Name,
                OwnerName = per.Name
            }).ToList();
        }

    }
}
