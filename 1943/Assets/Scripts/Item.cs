using UnityEngine;

public class Item : MonoBehaviour
{
    //아이템 가속 속도
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
        //파워와 플레이어 충돌
        if (collision.gameObject.CompareTag("Player"))
        {
            //파워업
            Player.power += 1;
            //자기자신 지우기
            Destroy(gameObject);
        }
    }
}
