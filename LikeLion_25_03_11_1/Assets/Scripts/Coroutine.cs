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
            Debug.Log("�� 1�ʸ��� ����!");
            yield return new WaitForSeconds(1f);   //2�ʴ��
        }
    }
}
