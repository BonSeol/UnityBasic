using UnityEngine;

public class e_Bullet : MonoBehaviour
{
    public float moveSpeed = 4f;
    public GameObject impact;

    void Start()
    {

    }

    void Update()
    {
        //Y�� �̵�
        transform.Translate(0, -moveSpeed * Time.deltaTime, 0);
    }

    private void OnBecameInvisible()
    {
        //�̻����� ȭ������� ��������
        //�̻��� ������
        Destroy(gameObject);
    }

    //2D�浹 Ʈ�����̺�Ʈ
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //�̻��ϰ� ���� �΋H����
        if (collision.gameObject.CompareTag("Player"))
        {
            Instantiate(impact, transform.position, Quaternion.identity);
            //���� ���
            GameManager.instance.HitLife(1);
            //�Ѿ� ����� �ڱ��ڽ�
            Destroy(gameObject);
        }

    }
}
