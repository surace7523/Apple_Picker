using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    public GameObject applePrefab;
    public float treeSpeed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DropApple", 2.0f);
    }
    void DropApple()
    {
        GameObject Apple = Instantiate<GameObject>(applePrefab);
        Apple.transform.position = transform.position;
        Invoke("DropApple", 1.0f);

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(treeSpeed * Time.deltaTime, 0, 0);

        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "bounds")
            treeSpeed *= -1.0f;
    }
}
