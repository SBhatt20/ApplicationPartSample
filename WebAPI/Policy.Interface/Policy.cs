using System;

namespace Policy.Interface
{
  public class PolicyPoco
  {
    public string Id { get; set; }

    public string PolicyTitle { get; set; }

    public DateTime DOE { get; set; }

    public int Premium { get; set; }
  }
}
