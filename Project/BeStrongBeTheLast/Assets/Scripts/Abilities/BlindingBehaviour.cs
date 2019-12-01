﻿/*
MIT License
Copyright (c) 2019: Francesco Dettori, Jacopo Frasson, Riccardo Lombardi, Michele Maione
Author: Riccardo Lombardi
Contributors:
Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions: The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlindingBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject blinded;

    private GameObject[] players;
    private GameObject[] bots;
    private GameObject user;

    // Start is called before the first frame update
    void Start()
    {
        user = transform.parent.gameObject;
        players = GameObject.FindGameObjectsWithTag("Player");
        foreach(GameObject player in players)
            if(player != user)
            {
                AbilityController ac = player.GetComponent<AbilityController>();
                if(ac != null)
                {
                    Instantiate(blinded, player.transform);
                    ac.blindingFront.enabled = true;
                    ac.blindingRear.enabled = true;
                }
            }
        bots = GameObject.FindGameObjectsWithTag("CPU");
        foreach(GameObject bot in bots)
        {
            //TO DO: Make them drive bad
        }
        StartCoroutine(Lifetime());
    }

    IEnumerator Lifetime()
    {
        yield return new WaitForSeconds(30f);
        foreach(GameObject player in players)
            if(player != user)
            {
                AbilityController ac = player.GetComponent<AbilityController>();
                if(ac != null)
                {
                    Destroy(player.transform.Find("Blinded(Clone)").gameObject);
                    ac.blindingFront.enabled = false;
                    ac.blindingRear.enabled = false;
                }
            }
        bots = GameObject.FindGameObjectsWithTag("CPU");
        foreach(GameObject bot in bots)
        {
            //TO DO: Make their drive return to normal
        }

        if(enabled)
            Destroy(gameObject);
    }
}
