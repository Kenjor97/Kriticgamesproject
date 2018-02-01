﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationMenus : MonoBehaviour
{
    public MouseCursor cursor;
    public Animator woodTable;
    public Animator anvil;
    public GameObject pressEnterText;
    public GameObject menuButtons;
    public AudioSource chainsSound;
    public AudioSource chainsDownSound;

	// Use this for initialization
	void Start ()
    {
        cursor = GetComponent<MouseCursor>();
        woodTable.enabled = false;
        anvil.enabled = false;
        pressEnterText.SetActive(true);
        menuButtons.SetActive(false);
        chainsSound = GetComponent<AudioSource>();
        chainsDownSound = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update ()
    {

        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Pressed Enter");
            woodTable.enabled = true;
            anvil.enabled = true;
            anvil.Rebind();
            woodTable.Rebind();
            pressEnterText.SetActive(false);
            menuButtons.SetActive(true);
            chainsSound.Play();
            chainsDownSound.PlayDelayed(2.0f);
        }

    }


}