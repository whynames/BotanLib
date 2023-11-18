using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace BotanLib
{
    [CreateAssetMenu(menuName = "Singleton/ParticleBank")]
    [AssetPath("ParticleBank")]
    public class ParticleBank : ScriptableSingletonAsset<ParticleBank>
    {
        public ParticleSystem OnDamage;
        public ParticleSystem OnTravel;
        public ParticleSystem Background;
        public ParticleSystem OnCollect;
        public ParticleSystem OnCollect2;




    }
}
