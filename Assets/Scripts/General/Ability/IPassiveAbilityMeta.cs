using System.Collections;
using System.Collections.Generic;
using AutoChessRPG.Entity;
using UnityEngine;
using UnityEngine.Serialization;

namespace AutoChessRPG
{
    public interface IPassiveAbilityMeta
    {
        public bool OnAttachPassive();

        public bool OnInterruptPassive();

        public bool OnRemovePassive();
    }
}