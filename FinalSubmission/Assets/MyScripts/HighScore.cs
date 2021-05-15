using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HighScore : MonoBehaviour
{
    // Start is called before the first frame update
    
    public Text ScoreText;
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        float time = ScoreKeeper.time190;
    ScoreText.text = time.ToString();
    }
}
