using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cache : MonoBehaviour
{
    //putting Camera into variable
    public Camera cam;

    float gameHeight;
    float gameWidth;
    private float leftExtent;
    private float rightExtent;

    void Awake()
    {
        //caching camera
        cam = Camera.main;
    }

    void Start()
    {
        
    }

    public void CacheCam()
    {
        gameHeight = cam.orthographicSize * 2f;
        gameWidth = cam.aspect * gameHeight;
        leftExtent = -gameWidth * 2f;
        rightExtent = gameWidth * 2f;
    }

    void Update()
    {
        CacheCam();
    }

}
