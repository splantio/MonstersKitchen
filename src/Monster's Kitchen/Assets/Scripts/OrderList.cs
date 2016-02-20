﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class OrderList : MonoBehaviour {
	public Queue <Order> orders;
	public float timeLimit;
    public OrderBlock[] orderBlocks;

	public OrderList(){
		orders = new Queue<Order>();
	}

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	// Here we handle Order drawing
	void Update () {
		foreach (Order order in orders) {
            timeLimit = order.TimeRemaining();
		}
	
	}

	public void AddOrder(Order order){
        if (orders.Count < orderBlocks.Length)
        {
            orderBlocks[orders.Count].SetOrder(order);
        }
		orders.Enqueue(order);
	}

}