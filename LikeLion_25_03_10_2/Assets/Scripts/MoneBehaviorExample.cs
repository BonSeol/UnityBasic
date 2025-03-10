using UnityEngine;

public class MoneBehaviorExample : MonoBehaviour
{

    void Start()
    {
        Debug.Log("Start : 게임이 시작될 때 호출");
    }

    void Update()
    {
        Debug.Log("Updata : 프레임마다 호출");
    }

    private void FixedUpdate()
    {
        Debug.Log("FixedUpdata : 물리 연산에 사용");
    }


}
