using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public TextMeshProUGUI playerNameInputText;

    // Start is called before the first frame update
    void Start()
    {
        
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            GlobalInfoData.RecordData data = JsonUtility.FromJson<GlobalInfoData.RecordData>(json);
            GlobalInfoData.Instance.recordData = data;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        GlobalInfoData.Instance.PlayerName = playerNameInputText.GetParsedText();
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {

#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

}
