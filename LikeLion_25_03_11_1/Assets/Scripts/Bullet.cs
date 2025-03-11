using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float moveSpeed = 0.45f;
    public GameObject explosion;

    void Start()
    {

    }

    void Update()
    {
        //Y축 이동
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);
    }

    private void OnBecameInvisible()
    {
        //미사일이 화면밖으로 나갔으면
        //미사일 지우자
        Destroy(gameObject);
    }

    //2D충돌 트리거이벤트
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //미사일과 적이 부딫혔다
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Instantiate(explosion, transform.position, Quaternion.identity);
            //적지우기
            Destroy(collision.gameObject);
            //총알 지우기 자기자신
            Destroy(gameObject);
            SoundManager.instance.SoundDie();
            GameManager.instance.AddScore(10);
        }


    }
}

