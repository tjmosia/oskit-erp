﻿using Microsoft.AspNetCore.Mvc;

namespace Moskit.Areas.Inventory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        public IActionResult CreateItemAsync ()
        {

            return Ok();
        }
    }
}
