﻿/*
MIT License
Copyright (c) 2019: Francesco Dettori, Jacopo Frasson, Riccardo Lombardi, Michele Maione
Author: Riccardo Lombardi
Contributors:
Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions: The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/
using UnityEngine;

public class RotatingBehaviour : aAbilitiesBehaviour
{

    private void Start()
    {
        Start_();

        user = transform.root.gameObject;
        StartCoroutine(Lifetime());
    }

    private void OnTriggerEnter(Collider other)
    {
        if (GB.CompareORTags(other, "Player", "CPU"))
            if (!other.transform.root.gameObject.Equals(user))
            {
                var kartCollision = other.transform.root.GetComponentInChildren<KartCollision>();

                kartCollision.countered = true;
                kartCollision.rotatingPush = 2f;
            }
    }

    protected override void LifeTimeElapsed()
    {
        // nothing
    }

}