﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rawMouse = Input.mousePosition;

       Vector3 convertedMouse = Camera.main.ScreenToWorldPoint(rawMouse);

       Vector3 pos = transform.position;
        pos.x = convertedMouse.x;

        transform.position = pos;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Apple")
        {
            Destroy(collision.gameObject);
            GameObject.Find("bounds").GetComponent<BoundryBehaviour>().IncrementScore();

        }

    }

}
