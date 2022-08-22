using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FlyweightDesignPattern
{
    public class ScriptableObjectSimilation
    {
        private readonly float _maxHp = 100f;
        private readonly float _attackSpeed = 1.5f;
        private float _attackPower = 15f;
        private float _attackRange = 45f;

        public float GetAttackPower() => _attackPower;
        public float GetAttackRange() => _attackRange;
        public float GetAttackSpeed() => _attackSpeed;
        public float GetMaxHp() => _maxHp;


    }
}
