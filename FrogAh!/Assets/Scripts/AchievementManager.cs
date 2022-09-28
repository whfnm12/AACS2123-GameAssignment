using System;
using TMPro;
using UnityEngine;

public class AchievementManager : MonoBehaviour
{
    public static AchievementManager Instance;

    [SerializeField] private TextMeshProUGUI trophyNameText;
    [SerializeField] private TextMeshProUGUI trophyDescText;

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
            achievementToUnlock.UnlockThisAchievement();

    }

    public void UpdateTrophyTextsUI(string trophyName, string trophyDesc)
    {
        trophyNameText.text = trophyName;
        trophyDescText.text = trophyDesc;
    }
}
    