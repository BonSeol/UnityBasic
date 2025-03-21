using UnityEngine;

public class Player : MonoBehaviour
{
    //스피드
    public float moveSpeed = 5f;

    Animator ani; //애니메이터를 가져올 변수

    public GameObject bullet1; //미사일 프리팹 가져올 변수
    public GameObject bullet2;
    public GameObject bullet3;
    public GameObject bullet4;
    public static int power = 1;
    public Transform pos = null;

    //아이템

    //레이져


    void Start()
    {
        ani = GetComponent<Animator>();
    }


    void Update()
    {
        //방향키에따른 움직임
        float moveX = moveSpeed * Time.deltaTime * Input.GetAxis("Horizontal");
        float moveY = moveSpeed * Time.deltaTime * Input.GetAxis("Vertical");

        // -1   0   1
        if (Input.GetAxis("Horizontal") <= -0.5f)
            ani.SetBool("left", true);
        else
            ani.SetBool("left", false);


        if (Input.GetAxis("Horizontal") >= 0.5f)
            ani.SetBool("right", true);
        else
            ani.SetBool("right", false);


        if (Input.GetAxis("Vertical") >= 0.5f)
        {
            ani.SetBool("up", true);
        }
        else
        {
            ani.SetBool("up", false);
        }

        //스페이스
        if (Input.GetKeyDown(KeyCode.Space))
        {
            switch (power)
            {
                case 1://미사일 프리팹, 런쳐포지션, 방향값 안줌
                    Instantiate(bullet1, transform.position, Quaternion.identity);
                    break;
                case 2:
                    Instantiate(bullet2, transform.position, Quaternion.identity);
                    break;
                case 3:
                    Instantiate(bullet3, transform.position, Quaternion.identity);
                    break;
                default:
                    Instantiate(bullet4, transform.position, Quaternion.identity);
                    break;
            }
        }





        transform.Translate(moveX, moveY, 0);



        //캐릭터의 월드 좌표를 뷰포트 좌표계로 변환해준다.
        Vector3 viewPos = Camera.main.WorldToViewportPoint(transform.position);
        viewPos.x = Mathf.Clamp01(viewPos.x); //x값을 0이상, 1이하로 제한한다.
        viewPos.y = Mathf.Clamp01(viewPos.y); //y값을 0이상, 1이하로 제한한다.
        Vector3 worldPos = Camera.main.ViewportToWorldPoint(viewPos);//다시월드좌표로 변환
        transform.position = worldPos; //좌표를 적용한다.




    }
}