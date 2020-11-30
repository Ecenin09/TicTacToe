using System.Collections.Generic;
using SignalsFramework;
using UnityEngine.UI;

namespace Data
{
    public static class Hub
    {
        public static readonly Signal<List<Text>> OnChooseField = new Signal<List<Text>>();
        public static readonly Signal OnWinPlayer = new Signal();
        public static readonly Signal OnWinAI = new Signal();
        public static readonly Signal OnButtonClick = new Signal();
        public static readonly Signal OnDraw = new Signal();
    }
}