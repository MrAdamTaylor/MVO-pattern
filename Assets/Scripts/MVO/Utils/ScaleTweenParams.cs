using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace MVO
{
    [Serializable]
    public struct ScaleTweenParams
    {
        public Vector3 Scale;
        public float Duration;
    }
}