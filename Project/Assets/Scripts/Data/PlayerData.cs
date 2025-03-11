using System.Collections.Generic;
using System.IO;
using UnityEngine;

[System.Serializable]
public class SaveData
{
    public string currentSkin; // �������� �������� �����
    public List<string> unlockedSkins; // ������ ���������������� ������
    public int coins; // ���������� �����
    public int highScore; // ��������� ����
}

public static class PlayerData
{
    private static string filePath = Path.Combine(Application.persistentDataPath, 
        "save.json");

    private static string currentSkin; // ������� �������� �����
    private static List<string> unlockedSkins = new List<string>(); 
    // ���������������� �����
    private static int coins; // ������
    private static int highScore; // ������

    public static string CurrentSkin => currentSkin;
    public static List<string> UnlockedSkins => unlockedSkins;
    public static int Coins => coins;
    public static int HighScore => highScore;

    // ���������� ������ � JSON-����
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

    // �������� ������ �� JSON-�����
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

    // ����� �������� �����
    public static void ChangeSkin(string skinName)
    {
        currentSkin = skinName;
        AddSkin(currentSkin);
    }

    // ���������� ������ ����� � ������ ����������������
    public static void AddSkin(string skinName)
    {
        if (!unlockedSkins.Contains(skinName))
        {
            unlockedSkins.Add(skinName);
        }
    }

    // ���������� �����
    public static void AddCoins(int amount)
    {
        coins += amount;
    }

    // ��������� ���������� �����
    public static void SetHighScore(int score)
    {
        if (score > highScore)
        {
            highScore = score;
        }
    }
}
