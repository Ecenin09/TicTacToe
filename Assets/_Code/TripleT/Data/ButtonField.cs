using System;
using UnityEngine;
using UnityEngine.UI;

namespace Data
{
    public class ButtonField : MonoBehaviour
    {
        public Text textField;
        private void OnEnable()
        {
            textField = GetComponentInChildren<Text>();
        }

        public void ButtonClick()
        {
            Hub.OnButtonClick.Fire();
        }
    }
}