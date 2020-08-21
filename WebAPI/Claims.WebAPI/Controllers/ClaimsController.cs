using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Policy.Interface;

namespace Claims.WebAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ClaimsController : ControllerBase
  {
    public ClaimsPoco GetClaims()
    {
      return new ClaimsPoco() { Id = "222", Claimant = "BusOwner", Title = "NewClaim" };
    }
  }
}
