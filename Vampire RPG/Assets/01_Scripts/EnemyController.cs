using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour, IDamageable {

    [SerializeField]
    public int Health {
        get {
            return health;
        }
        private set {
            health = value;
            if(value <= 0) {
                Die();
            }
        }
    }
    [SerializeField]
    private int health;

    public void TakeDamage(int _dmg) {
        Health -= _dmg;
    }

    private void Die() {
        Destroy(this.gameObject);
    }

}