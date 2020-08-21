using Microsoft.AspNetCore.Mvc;
using Policy.Interface;
using System;

namespace Address.Endpoint
{
  [Route("api/[controller]")]
  [ApiController]
  public class AddressController: ControllerBase
  {
    public AddressPoco GetAddrress()
    {
      return new AddressPoco() {Name = "Test", Address1 ="TestAddress",Phone = "9199999111",PIN="1212212" };
    }
  }
}
