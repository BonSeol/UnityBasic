using System.Collections;
using UnityEngine;

public class Coroutine : MonoBehaviour
{

    void Start()
    {
        //  StartCoroutine("ExampleCoroutine");
        StartCoroutine(ExampleCoroutine());
    }


    IEnumerator ExampleCoroutine()
    {
        while (true)
        {
            Debug.Log("매 1초마다 실행!");
            yield return new WaitForSeconds(1f);   //2초대기
        }
    }
}
