using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int score = 0;
    public int lives = 3;
    public GameObject[] hearts; 

    public static GameManager instanc;

    void Start()
    {
        
    }

    private void Awake()
    {
        if (instanc == null)
        {
            instanc = this;
        }
        else
        {
            Destroy(instanc);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (lives < 1)
        {
            Destroy(hearts[0].gameObject);
        }else if (lives < 2)
        {
            Destroy(hearts[1].gameObject);
        }else if (lives < 3)
        {
            Destroy(hearts[2].gameObject);
        }
    }

    public void AddLives(int value)
    {
        lives += value;
        if (lives == 0)
        {
            GameOver();
            lives = 0;
        }
        
    }
    public void AddScore(int value)
    {
        score += value;
        
    }

    public void GameOver()
    {
        SceneManager.LoadSceneAsync(2);
    }
}
