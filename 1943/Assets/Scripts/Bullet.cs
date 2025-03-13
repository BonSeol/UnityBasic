using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Speed = 4.0f;
    //���ݷ�
    //����Ʈ
    public GameObject effect;
    public GameObject item;

    void Update()
    {
        //�̻��� ���ʹ������� �����̱�
        //���� ���� * ���ǵ� * Ÿ��
        transform.Translate(Vector2.up * Speed * Time.deltaTime);
    }


    //ȭ������� �������
    private void OnBecameInvisible()
    {
        //�ڱ� �ڽ� �����
        Destroy(gameObject);
    }


    //�浹ó��
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Monster"))
        {

            //����Ʈ����
            GameObject go = Instantiate(effect, transform.position, Quaternion.identity);
            //1�ʵڿ� �����
            Destroy(go, 1);

            float randomItem = Random.Range(0f, 10f);
            //������ ����
            if(randomItem <= 2.5f)
            {
                Instantiate(item, transform.position, Quaternion.identity);
            }

            //����
            Destroy(collision.gameObject);

            //�̻��� ����
            Destroy(gameObject);

        }
    }
}