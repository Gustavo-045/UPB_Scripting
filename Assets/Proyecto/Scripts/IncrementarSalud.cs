using MoreMountains.CorgiEngine;
using MoreMountains.Tools;
using System.Collections;
using UnityEngine;

public class IncrementarSalud : MonoBehaviour, MMEventListener<PickableItemEvent>
{
    private Health salud_personaje;

    void OnEnable()
    {
        this.MMEventStartListening<PickableItemEvent>();
    }

    void OnDisable()
    {
        this.MMEventStopListening<PickableItemEvent>();
    }

    public virtual void OnMMEvent(PickableItemEvent e)
    {
        if (e.PickedItem.name == "PowerUpSalud")
        {
            IncrementarSaludJugador();
        }
    }

    public Health GetHealthComponent()
    {
        GameObject player = LevelManager.Instance.Players[0].gameObject;
        return player.GetComponent<Health>();
    }

    public void IncrementarSaludJugador()
    {
        salud_personaje = GetHealthComponent();
        if (salud_personaje != null)
        {
            // Llamar al método GetHealth para incrementar la salud en 2 puntos
            salud_personaje.GetHealth(2f, gameObject); 
        }
    }
}
