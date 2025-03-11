using UnityEngine;

public class Singleton : MonoBehaviour
{
    public static Singleton Instance { get; private set; }

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void PrintMessage()
    {
        Debug.Log("½Ì±ÛÅæ ¸Þ½ÃÁö Ãâ·Â");
    }
}
