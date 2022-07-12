using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public GameObject objects;
    public TextMesh scoreText;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateObjects", 1, 2); // 1초당 2개씩  파이프가 만들어지는 함수
    }

    public int Score
    {
        set
        {
            score = value;
            scoreText.text = Score.ToString();
        }

        get
        {
            return score;
        }

    }

    // Update is called once per frame
    void Update()
    {
     // 주기별 콜 하는 방법   
    }

    void CreateObjects()
    {
        Instantiate(objects, new Vector3(7.5f, Random.Range(-2f, 2.1f), 0), Quaternion.identity);
    }
}
