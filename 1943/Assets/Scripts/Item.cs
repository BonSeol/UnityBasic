using UnityEngine;

public class Item : MonoBehaviour
{
    //������ ���� �ӵ�
    public float ItemVelocity = 20f;
    Rigidbody2D rig = null;


    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.AddForce(new Vector3(ItemVelocity, ItemVelocity, 0f));
    }


    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //�Ŀ��� �÷��̾� �浹
        if (collision.gameObject.CompareTag("Player"))
        {
            //�Ŀ���
            Player.power += 1;
            //�ڱ��ڽ� �����
            Destroy(gameObject);
        }
    }
}
