using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoundryBehaviour : MonoBehaviour
{

    public int score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncrementScore()
    {

        score += 10;
        GameObject.Find("Score").GetComponent<Text>().text = score.ToString();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Apple")
            Destroy(collision.gameObject);
    }
}
