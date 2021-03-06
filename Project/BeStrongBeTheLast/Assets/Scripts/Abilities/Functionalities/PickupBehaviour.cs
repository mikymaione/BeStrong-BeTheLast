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

public class PickupBehaviour : PausableMonoBehaviour
{
    private Collider collider_;
    private MeshRenderer mesh;

    private Transform particle;

    [SerializeField]
    private float respawnTime = 15f;

    [SerializeField]
    private float powerAmount = 0.5f;

    private void Start()
    {
        collider_ = GetComponent<Collider>();
        mesh = GetComponentInChildren<MeshRenderer>();
        particle = transform.GetChild(1);
    }

    public void Update()
    {
        if(Paused)
            return;

        transform.Rotate(Vector3.up * 500f * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("CPU"))
        {
            KartController kartController = other.transform.root.GetComponentInChildren<KartController>();
            string playerName = kartController.transform.parent.gameObject.name;
            kartController.powerGaugeValue += (powerAmount + powerAmount * GameState.Instance.getScoreBiasBonus(playerName));
            collider_.enabled = false;
            mesh.enabled = false;
            particle.gameObject.SetActive(false);
            StartCoroutine(Respawn());
        }
    }

    IEnumerator Respawn()
    {
        yield return new WaitForSeconds(respawnTime);
        collider_.enabled = true;
        mesh.enabled = true;
        particle.gameObject.SetActive(true);
    }

}