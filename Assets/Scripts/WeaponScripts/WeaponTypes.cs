using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MetroidvaniaTools
{
    [CreateAssetMenu(fileName = "WeaponType", menuName = "Metroidvania/Weapons", order = 1)]
    public class WeaponTypes : ScriptableObject
    {
        public GameObject projectile;
        public float projectileSpeed;
        public int amountToPool;
        public float lifeTime;
        public bool automatic;
        public float timeBetweenShots;
        public bool canExpandPool;
        public bool canResetPool;

        protected virtual void OnEnabled()
        {
            if(canExpandPool && canResetPool)
            {
                canResetPool = false;
            }
        }

    }
}
