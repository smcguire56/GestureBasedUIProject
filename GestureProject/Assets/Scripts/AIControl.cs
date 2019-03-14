﻿using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof(CarController))]
    public class AIControl : MonoBehaviour
    {
        private CarController m_Car; // the car controller we want to use


        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
        }


        private void FixedUpdate()
        {
            // pass the input to the car!
            float h = 0;
            float v = 1;

            #if !MOBILE_INPUT
                        float handbrake = 0;
                        m_Car.Move(h, v, v, handbrake);
            #else
                        m_Car.Move(h, v, v, 0f);
            #endif
        }
    }
}
