using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Kraken.AbilitySystem
{
    public interface IGameplayEffect
    {
        public string Name { get; internal set; }
        public string ID { get; internal set; }
        public string Description { get; internal set; }

        protected void OnGameplayEffectApplied();
        protected void OnGameplayEffectRemoved();
        protected void Begin();
        protected void Tick();
        protected void End();
        
    }
}