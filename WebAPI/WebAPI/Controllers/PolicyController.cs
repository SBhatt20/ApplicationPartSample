using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Policy.Interface;

namespace Policy.WebAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class PolicyController : ControllerBase
  {
    public PolicyPoco GetPolicy()
    {
      return new PolicyPoco() { Id = "111", PolicyTitle = "TestPolicy", Premium = 10000, DOE = DateTime.Now };
    } 
  }
}
