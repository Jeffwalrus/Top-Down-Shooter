﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour {

    public bool isFiring;

    public BulletController bullet;
    public float bulletSpeed;

    public float timeBetweenShots;
    private float shotCounter;

    public Transform firePoint;
	// Use this for initialization

    public int ammoNo = 30;

	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (isFiring)
        {
            shotCounter -= Time.deltaTime;
            ammoNo -= 1;
            if (shotCounter <= 0)
            {
                shotCounter = timeBetweenShots;
               BulletController newBullet = Instantiate(bullet, firePoint.position, firePoint.rotation) as BulletController;
                newBullet.speed = bulletSpeed;
            }
        }
        else
        {
            shotCounter = 0;
        }
	}
}
