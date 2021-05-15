using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreKeeper : MonoBehaviour
{
    public static float time190=0;
    // Start is called before the first frame update
    public Text scoreText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time190 += Time.deltaTime;
        scoreText.text = time190.ToString("0");
    }
}
