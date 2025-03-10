using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float speed = 5.0f;

    void Update()
    {
        Vector3 move = new Vector3(1, 0, 0);
        transform.Translate(move * speed * Time.deltaTime);

    }
}
