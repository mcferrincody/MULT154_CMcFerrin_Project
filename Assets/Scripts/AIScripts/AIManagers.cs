using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MetroidvaniaTools 
{
    public class AIManagers : EnemyCharacter
    {
        protected EnemyCharacter enemyCharacter;

        protected override void Initialiazation()
        {
            base.Initialiazation();
            enemyCharacter = GetComponent<EnemyCharacter>();
        }

    }
}