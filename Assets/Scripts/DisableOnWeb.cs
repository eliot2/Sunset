﻿using UnityEngine;
using System.Collections;

public class DisableOnWeb : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Application.platform == RuntimePlatform.WebGLPlayer)
        {
            transform.gameObject.SetActive(false);
        }
	}
}
