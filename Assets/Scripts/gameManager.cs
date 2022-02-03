using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public GameObject square;
    public GameObject endText;
    public static gameManager I;
    public Text timeText;
    float time = 0.0f;
    public Animator anim;
    public GameObject balloon;
    void Awake()
    {
        I = this;
    }


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("makeSquare",0.0f, 0.5f);
    }
    void makeSquare()
    {
        Instantiate(square);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        timeText.text = time.ToString("N2");
    }
    public void gameOver() {
        anim.SetBool("isDie", true);
        endText.SetActive(true);
        Invoke("dead",0.5f);
    }
    void dead()
    {
        Time.timeScale = 0.0f;
        Destroy(balloon);

    }
}
