﻿using UnityEngine;
using System.Collections;

public class Laser :  Weapon 
{
	void Start()
	{
		bulletSpeed = 20;
		base.Start();
	}
}