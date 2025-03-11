using UnityEngine;

public class Enemy : MonoBehaviour
{
    //움직일 속도를 지정해 줍니다.
    public float moveSpeed = 1.3f;
    public GameObject explosion;

    void Start()
    {

    }


    void Update()
    {
        //움직일 거리를 계산해줍니다.
        float distanceY = moveSpeed * Time.deltaTime;

        //움직임을 반영합니다.
        transform.Translate(0, -distanceY, 0);
    }


    //화면 밖으로 나가 카메라에서 보이지 않으면 호출된다.
    private void OnBecameInvisible()
    {
        Destroy(gameObject); //객체를 삭제한다.
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //적과 나와 부딫혔다
        if (collision.gameObject.CompareTag("Player"))
        {
            Instantiate(explosion, transform.position, Quaternion.identity);
            //생명 깎기
            GameManager.instance.HitLife(1);
        }

    }


}