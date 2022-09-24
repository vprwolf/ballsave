using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class gameManager : MonoBehaviour
{
    public GameObject rain;
    public GameObject gameOverText;
    public static gameManager I;

    public Animator anim;
    public GameObject ball;

    public Text timeText;
    private float time;


    void Awake()
    {
        I = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("makeRain", 0.0f, 0.5f);
        initGame();
    }

    void initGame()
    {
     
    }

    void makeRain()
    {
        Instantiate(rain);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        timeText.text = time.ToString("N2");
    }

    public void gameOver()
    {
        anim.SetBool("isDie", true);
        gameOverText.SetActive(true);
        Invoke("dead", 0.5f);
    }

    void dead()
    {
        Time.timeScale = 0.0f;
        Destroy(ball);
    }


}
