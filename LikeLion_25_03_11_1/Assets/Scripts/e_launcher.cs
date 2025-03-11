using UnityEngine;
using static System.Net.WebRequestMethods;

public class e_launcher : MonoBehaviour
{
    public GameObject bullet; //미사일 프리팹 가져올 변수

    void Start()
    {
        //InvokeRepeating(함수이름,초기지연시간, 지연할 시간)
        InvokeRepeating("Shoot", 0.5f, 2.5f);
    }

    void Shoot()
    {
        //미사일 프리팹, 런쳐포지션, 방향값 안줌
        Instantiate(bullet, transform.position, Quaternion.identity);

    }
}
