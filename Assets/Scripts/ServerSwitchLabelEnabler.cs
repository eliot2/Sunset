﻿using UnityEngine;
using System.Collections;

public class ServerSwitchLabelEnabler : MonoBehaviour {
    

    public GameObject WestArrow;
    public GameObject EastArrow;

    private int server;
    private ConnectAndJoinRandom n;

	// Use this for initialization
	void Awake () {

        n = GameObject.FindGameObjectWithTag("Networking").GetComponent<ConnectAndJoinRandom>();

        server = PlayerPrefs.GetInt("Server", 0);
        if (server == 0)
            return;

        WestArrow.SetActive(server == 2 ? true : false);
        EastArrow.SetActive(server == 1 ? true : false);
    }
	
	// Update is called once per frame
	void Update () {
	
	}


}
