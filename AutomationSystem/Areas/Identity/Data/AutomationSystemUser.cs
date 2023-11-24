using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace AutomationSystem.Areas.Identity.Data;

// Add profile data for application users by adding properties to the AutomationSystemUser class
public class AutomationSystemUser : IdentityUser
{

    public string Name { get; set; }

    public string SecondName { get; set; }

}

