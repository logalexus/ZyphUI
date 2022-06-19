using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.ZyphUI.Extensions
{
    public static class Extensions
    {
        public static void SetZ(this Transform self, float value)
        {
            self.position = new Vector3(self.position.x, self.position.y, value);
        }
    }
}
