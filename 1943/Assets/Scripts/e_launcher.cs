using UnityEngine;
using static System.Net.WebRequestMethods;

public class e_launcher : MonoBehaviour
{
    public GameObject bullet; //�̻��� ������ ������ ����

    void Start()
    {
        //InvokeRepeating(�Լ��̸�,�ʱ������ð�, ������ �ð�)
        InvokeRepeating("Shoot", 0.5f, 2f);
    }

    void Shoot()
    {
        //�̻��� ������, ����������, ���Ⱚ ����
        Instantiate(bullet, transform.position, Quaternion.identity);

    }
}
