using System;
using System.Collections.Generic;
using Data;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace Logic
{
    public class GameLogic : MonoBehaviour
    {
        private bool isGameOn;
        private void OnEnable()
        {
            Hub.OnChooseField.Subscribe(x=>ChekField(x)).AddTo(this);
        }

        private void Start()
        {
            isGameOn = true;
        }

        void ChekField(List<Text> data)
        {
            string winChar = null;
            if (data[0] == data[1] == data[2]) winChar = data[0].text;
            else if (data[3] == data[4] == data[5]) winChar = data[3].text;
            else if (data[6] == data[7] == data[8]) winChar = data[6].text;
            else if (data[0] == data[3] == data[6]) winChar = data[0].text;
            else if (data[1] == data[4] == data[7]) winChar = data[1].text;
            else if (data[2] == data[5] == data[8]) winChar = data[2].text;
            else if (data[0] == data[4] == data[8]) winChar = data[0].text;
            else if (data[2] == data[4] == data[6]) winChar = data[0].text;
            else Hub.OnDraw.Fire();

            if (winChar != null&&isGameOn)
            {
                if (GameData.PlayerChar==winChar)
                {
                    Hub.OnWinPlayer.Fire();
                }
                else
                {
                    Hub.OnWinAI.Fire();
                }
            }

            if (isGameOn)
            {
                
            }
        }
        
        void IsPlayerWin(bool inputData)
        {
            if (inputData)
            {
                Hub.OnWinPlayer.Fire();
            }
            else
            {
                Hub.OnWinAI.Fire();
            }
        }
    }
}