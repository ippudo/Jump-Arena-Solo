﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Arena
{
    public class CoinPowerup : MonoBehaviour
    {
        public int coin;
        public int score;

        // Use this for initialization
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {

        }
        void OnTriggerEnter2D(Collider2D e)
        {
            if (e.gameObject.tag.CompareTo("Player") == 0)
            {
                //Player player = e.GetComponent<Player>();
                //player.AddBuff("JumpMulDelta", value, time);
                MainHelper.Instance.coin+=coin;
                MainHelper.Instance.score += score;
                Destroy(gameObject);
            }
        }
    }
}