using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartPresentations.Abstractions
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public abstract class ApiBaseController : ControllerBase
    {
        protected readonly ISender Sender;

        protected ApiBaseController(ISender sender)
        {
            Sender = sender;
        }


    }
}
