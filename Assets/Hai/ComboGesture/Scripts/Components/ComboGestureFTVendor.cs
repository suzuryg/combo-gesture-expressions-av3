﻿using System;
using UnityEngine;

namespace Hai.ComboGesture.Scripts.Components
{
    public abstract class ComboGestureFTVendor : MonoBehaviour
    {
        public abstract CgeElementActuator[] ToElementActuators();
    }
    
    [Serializable]
    public struct CgeElementActuator
    {
        public CgeElement element;
        public CgeActuator actuator;
    }

    [Serializable]
    public struct CgeActuator
    {
        public string parameter;
        public float neutral;
        public float actuated;
    }

    public enum CgeElement
    {
        Jaw_Right,
        Jaw_Left,
        Jaw_Forward,
        Jaw_Open,
        Mouth_Ape_Shape,
        Mouth_Upper_Right,
        Mouth_Upper_Left,
        Mouth_Lower_Right,
        Mouth_Lower_Left,
        Mouth_Upper_Overturn,
        Mouth_Lower_Overturn,
        Mouth_Pout,
        Mouth_Smile_Right,
        Mouth_Smile_Left,
        Mouth_Sad_Right,
        Mouth_Sad_Left,
        Cheek_Puff_Right,
        Cheek_Puff_Left,
        Cheek_Suck,
        Mouth_Upper_UpRight,
        Mouth_Upper_UpLeft,
        Mouth_Lower_DownRight,
        Mouth_Lower_DownLeft,
        Mouth_Upper_Inside,
        Mouth_Lower_Inside,
        Mouth_Lower_Overlay,
        Tongue_LongStep1,
        Tongue_LongStep2,
        Tongue_Down,
        Tongue_Up,
        Tongue_Right,
        Tongue_Left,
        Tongue_Roll,
        Tongue_UpLeft_Morph,
        Tongue_UpRight_Morph,
        Tongue_DownLeft_Morph,
        Tongue_DownRight_Morph,
        Eye_Left_Blink,
        Eye_Left_Wide,
        Eye_Left_Right,
        Eye_Left_Left,
        Eye_Left_Up,
        Eye_Left_Down,
        Eye_Right_Blink,
        Eye_Right_Wide,
        Eye_Right_Right,
        Eye_Right_Left,
        Eye_Right_Up,
        Eye_Right_Down,
        // Eye_Frown,
        Eye_Left_Frown,
        Eye_Right_Frown,
        Eye_Left_Squeeze,
        Eye_Right_Squeeze,
        Eye_Left_Dilation,
        Eye_Left_Constrict,
        Eye_Right_Dilation,
        Eye_Right_Constrict
    }

    [Serializable]
    public struct CgeSensorLipMap
    {
        public CgeActuator Jaw_Right;
        public CgeActuator Jaw_Left;
        public CgeActuator Jaw_Forward;
        public CgeActuator Jaw_Open;
        public CgeActuator Mouth_Ape_Shape;
        public CgeActuator Mouth_Upper_Right;
        public CgeActuator Mouth_Upper_Left;
        public CgeActuator Mouth_Lower_Right;
        public CgeActuator Mouth_Lower_Left;
        public CgeActuator Mouth_Upper_Overturn;
        public CgeActuator Mouth_Lower_Overturn;
        public CgeActuator Mouth_Pout;
        public CgeActuator Mouth_Smile_Right;
        public CgeActuator Mouth_Smile_Left;
        public CgeActuator Mouth_Sad_Right;
        public CgeActuator Mouth_Sad_Left;
        public CgeActuator Cheek_Puff_Right;
        public CgeActuator Cheek_Puff_Left;
        public CgeActuator Cheek_Suck;
        public CgeActuator Mouth_Upper_UpRight;
        public CgeActuator Mouth_Upper_UpLeft;
        public CgeActuator Mouth_Lower_DownRight;
        public CgeActuator Mouth_Lower_DownLeft;
        public CgeActuator Mouth_Upper_Inside;
        public CgeActuator Mouth_Lower_Inside;
        public CgeActuator Mouth_Lower_Overlay;
        public CgeActuator Tongue_LongStep1;
        public CgeActuator Tongue_LongStep2;
        public CgeActuator Tongue_Down;
        public CgeActuator Tongue_Up;
        public CgeActuator Tongue_Right;
        public CgeActuator Tongue_Left;
        public CgeActuator Tongue_Roll;
        public CgeActuator Tongue_UpLeft_Morph;
        public CgeActuator Tongue_UpRight_Morph;
        public CgeActuator Tongue_DownLeft_Morph;
        public CgeActuator Tongue_DownRight_Morph;
    }

    [Serializable]
    public struct CgeSensorEyeMap
    {
        public CgeActuator Eye_Left_Blink;
        public CgeActuator Eye_Left_Wide;
        public CgeActuator Eye_Left_Right;
        public CgeActuator Eye_Left_Left;
        public CgeActuator Eye_Left_Up;
        public CgeActuator Eye_Left_Down;
        public CgeActuator Eye_Right_Blink;
        public CgeActuator Eye_Right_Wide;
        public CgeActuator Eye_Right_Right;
        public CgeActuator Eye_Right_Left;
        public CgeActuator Eye_Right_Up;
        public CgeActuator Eye_Right_Down;
        public CgeActuator Eye_Frown;
        public CgeActuator Eye_Left_Squeeze;
        public CgeActuator Eye_Right_Squeeze;
    }
}