using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalInfoData : MonoBehaviour
{
    public static GlobalInfoData Instance;

    public string PlayerName;
    public int RecordScore;
    public string RecordPlayerName;

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
}
