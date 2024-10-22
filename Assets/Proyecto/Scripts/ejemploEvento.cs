using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;

public class ejemploEvento : MonoBehaviour, MMEventListener<PickableItemEvent>
{

    private int contador_monedas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
        if(contador_monedas>=10)
        {
            GameManager.Instance.AddPoints(100);
            GameManager.Instance.GainLives(2);
            contador_monedas = 0;
            
        }
        else
        {
            contador_monedas++;
            MMAchievementManager.AddProgress ("Coin", 1);
        }
       
    }

        public void checkAchievement()
    {
        
    }
}
