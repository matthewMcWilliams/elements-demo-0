using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class LayerHelper
{
    public static bool IntIsOnLayer(int layer, LayerMask layerMask)
    {
        return layerMask == (layerMask | (1 << layer));
    }

    public static bool ColliderIsOnLayer(Collider2D collider, LayerMask layerMask) => IntIsOnLayer(collider.gameObject.layer, layerMask);
}
