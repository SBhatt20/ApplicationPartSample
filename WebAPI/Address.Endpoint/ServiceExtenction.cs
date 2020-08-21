using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Address.Endpoint
{
  public static class ServiceExtenction
  {
    public static IMvcBuilder AddAddressBuilder(this IMvcBuilder builder)
    {
      var addressAssembly = typeof(AddressController).Assembly;

      builder.AddApplicationPart(addressAssembly);

      return builder;
    }
  }
}
