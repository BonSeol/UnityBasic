using System.Collections;
using System.Net.Sockets;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Text scoreText;
    public Text lifeText;
    public Text StartText;
    public Text EndText;

    int score = 0;
    int life = 5;


    private void Awake()
    {
       if(instance == null)
        {
            instance = this;
        }
        EndText.gameObject.SetActive(false);  //UI감추기
        lifeText.text = "Life : " + life;
    }

    void Start()
    {
        StartCoroutine("StartGame");
    }

    void FixedUpdate()
    {
        if(life <= 0)
        {
            EndGame();
        }
    }

    public void AddScore(int num)
    {
        score += num;
        scoreText.text = "Score : " + score;
    }

    public void HitLife(int num)
    {
        life -= num;
        lifeText.text = "Life : " + life;
    }

    IEnumerator StartGame()
    {
        int i = 3;

        Time.timeScale = 0; //전체 시간멈춤

        while (i > 0)
        {
            StartText.text = i.ToString();

            //  yield return new WaitForSeconds(1);
            yield return new WaitForSecondsRealtime(1); //게임이 멈춰도 동작하는 대기
            i--;

            if (i == 0)
            {
                StartText.gameObject.SetActive(false);  //UI감추기
                Time.timeScale = 1; //다시 시간 정상으로
            }
        }
    }
    public void EndGame()
    {
        Time.timeScale = 0;
        EndText.gameObject.SetActive(true);
    }
}
