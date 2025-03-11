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
        EndText.gameObject.SetActive(false);  //UI���߱�
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

        Time.timeScale = 0; //��ü �ð�����

        while (i > 0)
        {
            StartText.text = i.ToString();

            //  yield return new WaitForSeconds(1);
            yield return new WaitForSecondsRealtime(1); //������ ���絵 �����ϴ� ���
            i--;

            if (i == 0)
            {
                StartText.gameObject.SetActive(false);  //UI���߱�
                Time.timeScale = 1; //�ٽ� �ð� ��������
            }
        }
    }
    public void EndGame()
    {
        Time.timeScale = 0;
        EndText.gameObject.SetActive(true);
    }
}
