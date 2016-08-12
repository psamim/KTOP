﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace KTOP.UnitTests
{
    public class PersianShapeTests
    {
        [Fact]
        public void VirtualSpaceCorrectionTest()
        {
            var samples = new List<string>();
            samples.Add("ﻧﮑﺘﻪﻫﺎﯼ");
            samples.Add("فرمت‌های");
            samples.Add("می¬رویم");


            var expected = new List<string>();
            expected.Add("ﻧﮑﺘﻪﻫﺎﯼ");
            expected.Add("ﻓﺮﻣﺖ‌ﻫﺎﯼ");
            expected.Add("ﻣﯽ¬ﺭﻭﯾﻢ");
            
            for(var i = 0;i<samples.Count;i++)
            {
                var dest = ArabicShaping.ArabicLigaturizer.ArabicShape(samples[i]);
                Assert.Equal(expected[i], dest);
            }
        }
    }
}
