using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ResearchArcade
{
    public class Binding
    {
        private KeyCode keycode;

        public bool HeldDown => Input.GetKey(this.keycode);
        public bool Down     => Input.GetKeyDown(this.keycode);
        public bool Up       => Input.GetKeyUp(this.keycode);

        public Binding(KeyCode keycode)
        {
            this.keycode = keycode;
        }
    }
}