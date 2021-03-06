﻿using System.Collections.Generic;

namespace Oak.Tests.describe_DynamicModel.describe_Validation.Classes
{
    public class Coffee : DynamicModel
    {
        public Coffee()
        {
            Init();
        }

        public IEnumerable<dynamic> Validates()
        {
            yield return new Inclusion("Size") { In = new[] { "small", "medium", "large" } };
        }
    }
}
