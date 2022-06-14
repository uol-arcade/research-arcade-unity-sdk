using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ResearchArcade
{
    public class ArcadeInput
    {
        public static PlayerKeymap Player1 = new PlayerKeymap()
        {
            A = new Binding(KeyCode.Z),
            B = new Binding(KeyCode.X),
            C = new Binding(KeyCode.C),
            D = new Binding(KeyCode.V),
            E = new Binding(KeyCode.B),
            F = new Binding(KeyCode.N),

            JoyUp = new Binding(KeyCode.UpArrow),
            JoyDown = new Binding(KeyCode.DownArrow),
            JoyLeft = new Binding(KeyCode.LeftArrow),
            JoyRight = new Binding(KeyCode.RightArrow),

            Start = new Binding(KeyCode.Return)
        };

        public static PlayerKeymap Player2 = new PlayerKeymap()
        {
            A = new Binding(KeyCode.F),
            B = new Binding(KeyCode.G),
            C = new Binding(KeyCode.H),
            D = new Binding(KeyCode.J),
            E = new Binding(KeyCode.K),
            F = new Binding(KeyCode.L),

            JoyUp = new Binding(KeyCode.W),
            JoyDown = new Binding(KeyCode.S),
            JoyLeft = new Binding(KeyCode.A),
            JoyRight = new Binding(KeyCode.D),

            Start = new Binding(KeyCode.Backspace)
        };

        public static Binding Exit = new Binding(KeyCode.Q);
    }
}
