using UnityEngine;

public class Enemy : MonoBehaviour
{
    //������ �ӵ��� ������ �ݴϴ�.
    public float moveSpeed = 1.3f;
    public GameObject explosion;

    void Start()
    {

    }


    void Update()
    {
        //������ �Ÿ��� ������ݴϴ�.
        float distanceY = moveSpeed * Time.deltaTime;

        //�������� �ݿ��մϴ�.
        transform.Translate(0, -distanceY, 0);
    }


    //ȭ�� ������ ���� ī�޶󿡼� ������ ������ ȣ��ȴ�.
    private void OnBecameInvisible()
    {
        Destroy(gameObject); //��ü�� �����Ѵ�.
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //���� ���� �΋H����
        if (collision.gameObject.CompareTag("Player"))
        {
            Instantiate(explosion, transform.position, Quaternion.identity);
            //���� ���
            GameManager.instance.HitLife(1);
        }

    }


}