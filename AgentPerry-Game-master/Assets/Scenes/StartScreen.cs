using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace RunAndJump
{
    public class StartScreen : BaseScene
    {

        public Text BuildInfoText;

        private void Start()
        {
            SetBuildInfo();
            //AudioPlayer.Instance.StopBgm();
        }

        private void SetBuildInfo()
        {
            string info = "";
            BuildInfoText.text = info;
        }

        public void ActiveZoneOnClick()
        {
           GoToScene(Scene.level1);
        }
    }
}