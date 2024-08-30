using MoreMountains.CorgiEngine;
using MoreMountains.Tools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HabilidadVelocidad : MonoBehaviour, MMEventListener<PickableItemEvent>
{
    private CharacterRun runHabilidad; 
    public float duracionRun = 5f; // Duración de la habilidad en segundos
    private bool _habilidadActiva = false;

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
        if (e.PickedItem.name == "PowerUpRun")
        {
            ActivarHabilidadVelocidad();
        }
    }

    public CharacterRun GetRunComponent()
    {
        GameObject player = LevelManager.Instance.Players[0].gameObject;
        return player.GetComponent<CharacterRun>();
    }

    public void ActivarHabilidadVelocidad()
    {
        runHabilidad = GetRunComponent();
        if (runHabilidad != null)
        {
            // Permitir la habilidad de Dash (habilitar la habilidad de velocidad)
            runHabilidad.PermitAbility(true);

            _habilidadActiva = true;
            StartCoroutine(DesactivarHabilidadRun());
        }
    }


    public  IEnumerator DesactivarHabilidadRun()
    {
        yield return new WaitForSeconds(duracionRun);
        
        if (runHabilidad != null)
        {
            // Desactivar la habilidad de Dash
            runHabilidad.PermitAbility(false);
        }
        _habilidadActiva = false;
    }
}
