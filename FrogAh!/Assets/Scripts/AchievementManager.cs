using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AchievementManager : MonoBehaviour
{
    public static AchievementManager Instance;

    [SerializeField] private TextMeshProUGUI TrophyName;
    [SerializeField] private TextMeshProUGUI TrophyDesc;

    [SerializeField] private Achievement[] trophies;

    private void Awake()
    {
        Instance = this;
    }

    public void UnlockAchievement(Achievement.AchievementTypes achievementType)
    {
        Achievement achievementToUnlock = 
            Array.Find(trophies, dummyTrophies => dummyTrophies._achievementType == achievementType);

        if(achievementToUnlock == null)
        {
            Debug.LogWarning("Trophy not added with achievement: " + achievementType);
            return;
        }

        if (!achievementToUnlock.isUnlocked)
        {
            achievementToUnlock.UnlockThisAchievement();
        }
    }

    //public void UpdateTrophyTextsUI(string TrophyName, string TrophyDesc)
    //{
    //    TrophyName.text = TrophyName;
    //    TrophyDesc.text = TrophyDesc;
    //}
}
    