using UnityEngine;

public class VectorStudy : MonoBehaviour
{
    void Start()
    {
        Vector3 a = new Vector3(1, 0, 0);
        Vector3 b = new Vector3(1, 1, 1);

        Vector3 c = a + b;

        Debug.Log("Vector" + c);
    }

    void Update()
    {
        
    }
}
