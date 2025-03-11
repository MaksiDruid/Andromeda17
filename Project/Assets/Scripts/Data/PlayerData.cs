using System.Collections.Generic;
using System.IO;
using UnityEngine;

[System.Serializable]
public class SaveData
{
    public string currentSkin; // Название текущего скина
    public List<string> unlockedSkins; // Список разблокированных скинов
    public int coins; // Количество монет
    public int highScore; // Рекордный счёт
}

public static class PlayerData
{
    private static string filePath = Path.Combine(Application.persistentDataPath, 
        "save.json");

    private static string currentSkin; // Текущее название скина
    private static List<string> unlockedSkins = new List<string>(); 
    // Разблокированные скины
    private static int coins; // Монеты
    private static int highScore; // Рекорд

    public static string CurrentSkin => currentSkin;
    public static List<string> UnlockedSkins => unlockedSkins;
    public static int Coins => coins;
    public static int HighScore => highScore;

    // Сохранение данных в JSON-файл
    public static void Save()
    {
        SaveData data = new SaveData
        {
            currentSkin = currentSkin,
            unlockedSkins = unlockedSkins,
            coins = coins,
            highScore = highScore
        };

        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(filePath, json);
    }

    // Загрузка данных из JSON-файла
    public static void Load()
    {
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            currentSkin = data.currentSkin;
            unlockedSkins = data.unlockedSkins ?? new List<string>();
            coins = data.coins;
            highScore = data.highScore;
        }
    }

    // Смена текущего скина
    public static void ChangeSkin(string skinName)
    {
        currentSkin = skinName;
        AddSkin(currentSkin);
    }

    // Добавление нового скина в список разблокированных
    public static void AddSkin(string skinName)
    {
        if (!unlockedSkins.Contains(skinName))
        {
            unlockedSkins.Add(skinName);
        }
    }

    // Добавление монет
    public static void AddCoins(int amount)
    {
        coins += amount;
    }

    // Установка рекордного счёта
    public static void SetHighScore(int score)
    {
        if (score > highScore)
        {
            highScore = score;
        }
    }
}
