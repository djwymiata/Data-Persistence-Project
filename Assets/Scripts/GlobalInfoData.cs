using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalInfoData : MonoBehaviour
{
    public static GlobalInfoData Instance;

    public string PlayerName;
    public RecordData recordData;

    [Serializable]
    public class RecordData
    {
        public int recordScore;
        public string recordPlayerName;
    }

    // Start is called before the first frame update
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SaveRecordData()
    {
        string json = JsonUtility.ToJson(GlobalInfoData.Instance.recordData);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
        Debug.Log("Data Saved. " + Application.persistentDataPath);
    }
}
