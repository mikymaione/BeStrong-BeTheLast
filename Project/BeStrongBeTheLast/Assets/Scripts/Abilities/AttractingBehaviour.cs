﻿/*
MIT License
Copyright (c) 2019: Francesco Dettori, Jacopo Frasson, Riccardo Lombardi, Michele Maione
Author: Riccardo Lombardi
Contributors:
Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions: The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/
using System.Collections;
using UnityEngine;

public class AttractingBehaviour : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private float shrinkingSpeed;

    private GameObject projectile;

    private bool attracting;

    private AbilityController abilityController;

    void Start()
    {
        StartCoroutine(Lifetime());
        abilityController = GetComponentInParent<AbilityController>();
    }

    private void Update()
    {
        if(attracting && !abilityController.attracted)
        {
            projectile.transform.LookAt(transform);
            projectile.transform.Translate(Vector3.forward * speed * Time.deltaTime);
            projectile.transform.localScale -= Vector3.one * shrinkingSpeed * Time.deltaTime;
            if(Vector3.Distance(projectile.transform.position, transform.position) <= 1f)
            {
                Destroy(projectile);
                abilityController.attracted = true;
                Destroy(this.gameObject);
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(!attracting && other.CompareTag("Projectile"))
        {
            if(other.name.Equals("Homing(Clone)"))
            {
                other.GetComponent<HomingBehaviour>().enabled = false;
                abilityController.selectedProjectile = abilityController.homing;
            }    
            else if(other.name.Equals("Trishot(Clone)"))
            {
                other.GetComponent<TrishotBehaviour>().enabled = false;
                SingleShotBehaviour[] singleShots = other.GetComponentsInChildren<SingleShotBehaviour>();
                foreach (SingleShotBehaviour singleShot in singleShots)
                    singleShot.enabled = false;
                abilityController.selectedProjectile = abilityController.trishot;
            }
            projectile = other.gameObject;
            attracting = true;
        }
    }

    IEnumerator Lifetime()
    {
        yield return new WaitForSeconds(5f);
        Destroy(this.gameObject);
    }
}
