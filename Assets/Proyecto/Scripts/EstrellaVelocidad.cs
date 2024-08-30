using MoreMountains.CorgiEngine;
using MoreMountains.Tools;
using UnityEngine;

public class EstrellaVelocidad : PickableItem
{
    protected override void Pick(GameObject picker)
    {
        // Disparar un evento cuando se recoge la estrella
        MMEventManager.TriggerEvent(new PickableItemEvent(this));
        // Destruir el objeto una vez recogido
        Destroy(gameObject);
    }
}
