using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElectricityBillingAutomation.Models { public class BillValidator { public string ValidateUnitsConsumed(int units) { if (units < 0) return "Units consumed cannot be negative."; return "Valid"; } } }