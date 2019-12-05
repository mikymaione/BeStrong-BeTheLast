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

public class AnnoyingBehaviour : aAbilitiesBehaviour
{
    [SerializeField]
    private float lengthTimeInSeconds = 15f;

    [SerializeField]
    private float annoyingAmount = 0.5f;

    private GameObject user;

    private GameObject[] players, bots;

    // Start is called before the first frame update
    void Start()
    {
        user = transform.parent.gameObject;
        players = GameObject.FindGameObjectsWithTag("Player");
        bots = GameObject.FindGameObjectsWithTag("CPU");

        AnnoyCars(players, annoyingAmount, true);
        AnnoyCars(bots, annoyingAmount, true);

        StartCoroutine(Lifetime());
    }

    IEnumerator Lifetime()
    {
        yield return new WaitForSeconds(lengthTimeInSeconds);

        AnnoyCars(players, annoyingAmount, false);
        AnnoyCars(bots, annoyingAmount, false);

        if(enabled)
            Destroy(gameObject);
    }

    private void AnnoyCars(GameObject[] cars, float annoyingAmount, bool annoyed)
    {
        foreach(var car in cars)
            //if(car != null && car != user)
            {
                var kartController = car.GetComponent<KartController>();

                if(kartController)
                    kartController.annoyMe(annoyingAmount, annoyed);
            }
    }
}
