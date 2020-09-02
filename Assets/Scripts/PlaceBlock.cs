﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceBlock : MonoBehaviour
{
    public GameObject block;
    GameObject a;
    public Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            a = Instantiate(block);
            a.transform.position = (Vector2)cam.ScreenToWorldPoint(Input.mousePosition);
        }
    }
}
