using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ResearchArcade
{
    public class Navigation
    {
        private const string RESEARCH_ARCADE_REDIRECT_URL = @"https://lncn.ac/rarcade";

        public void ExitGame()
        {
            //Open the URL
            Application.OpenURL(RESEARCH_ARCADE_REDIRECT_URL);

            //As a fallback, somehow, if this is running in desktop mode
            Application.Quit(-1);
        }
    }
}