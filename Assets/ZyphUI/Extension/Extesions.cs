using UnityEngine;

namespace Assets.ZyphUI.Extension
{
    public static class Extesions
    {
        public static void SetY(this RectTransform self, float y)
        {
            self.localPosition = new Vector3(self.localPosition.x, y);
        }

        public static void SetX(this RectTransform self, float x)
        {
            self.localPosition = new Vector3(x, self.localPosition.y);
        }

    }
}
