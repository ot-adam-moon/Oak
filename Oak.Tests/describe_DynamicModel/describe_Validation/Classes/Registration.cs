﻿using System.Collections.Generic;

namespace Oak.Tests.describe_DynamicModel.describe_Validation.Classes
{
    public class Registration : DynamicModel
    {
        public Registration()
        {
            Init();
        }

        public IEnumerable<dynamic> Validates()
        {
            yield return new Exclusion("UserName") { In = new[] { "admin", "administrator" } };
        }
    }
}
