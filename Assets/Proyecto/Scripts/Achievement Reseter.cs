using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;
public class AchievementReseter : MonoBehaviour
{
    // Método para resetear los logros
    public void ResetAchievements()
    {
        // Cargar el ScriptableObject desde la carpeta Resources
        MMAchievementList achievementList = Resources.Load<MMAchievementList>("Achievements/AchievementList");

        // Asegurarse de que el objeto fue cargado correctamente
        if (achievementList != null)
        {
            // Llamar al método ResetAchievements() de MMAchievementList
            achievementList.ResetAchievements();
            Debug.Log("Achievements reseteados.");
        }
        else
        {
            Debug.LogError("No se encontró la lista de logros en Resources.");
        }
    }
}