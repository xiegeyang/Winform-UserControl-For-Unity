using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using UnityUserControl_Interface;

namespace Unity
{
    public partial class UnityControl : UserControl
    {
        float value = 0f;
        public UnityControl(string src)
        {
            InitializeComponent(src);            
        }

        private void axUnityWebPlayer1_OnExternalCall(object sender, AxUnityWebPlayerAXLib._DUnityWebPlayerAXEvents_OnExternalCallEvent e)
        {
            
        }
        

        public void ChangePos(double anklePos)
        {
            value =  (float)anklePos;
            axUnityWebPlayer1.SendMessage("Done_Player", "ChangePos", value);            
        }       

        public void PauseGame()
        {
            axUnityWebPlayer1.SendMessage("Done_Player", "PauseGame", null);
        }

        public void ResumeGame()
        {
            axUnityWebPlayer1.SendMessage("Done_Player", "ResumeGame", null);
        }

        public void LevelChange(int lvl)
        {
            axUnityWebPlayer1.SendMessage("Done_Player", "LevelChange", lvl);
        }

        
    }
}
