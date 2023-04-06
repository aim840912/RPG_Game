using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    private GameData gameDate;

    public static SaveManager instance;

    private void Awake()
    {
        if (instance != null)
            Destroy(instance.gameObject);
        else
            instance = this;
    }

    private void Start()
    {
        LoadGame();
    }

    public void NewGame()
    {
        gameDate = new GameData();
    }

    public void LoadGame()
    {
        if (this.gameDate == null)
        {
            NewGame();
        }
    }

    public void SaveGame()
    {

    }

    private void OnApplicationQuit()
    {
        SaveGame();
    }
}
