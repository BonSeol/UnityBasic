using UnityEngine;

public class launcher : MonoBehaviour
{
    public GameObject bullet1; //미사일 프리팹 가져올 변수
    public GameObject bullet2;
    public GameObject bullet3;
    public GameObject bullet4;
    public static int power = 1;

    void Start()
    {
        //InvokeRepeating(함수이름,초기지연시간, 지연할 시간)
        InvokeRepeating("Shoot", 0.5f, 0.25f);
    }

    void Shoot()
    {
        switch (power)
        {
            case 1://미사일 프리팹, 런쳐포지션, 방향값 안줌
                Instantiate(bullet1, transform.position, Quaternion.identity);
                break;
            case 2 :
                Instantiate(bullet2, transform.position, Quaternion.identity);
                break;
            case 3 :
                Instantiate(bullet3, transform.position, Quaternion.identity);
                break;
            default :
                Instantiate(bullet4, transform.position, Quaternion.identity);
                break;
        }
    }


    void Update()
    {

    }
}