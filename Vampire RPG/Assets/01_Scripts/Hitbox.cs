using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitbox : MonoBehaviour {

    private int damage;

    public void Initialize(int _dmg) {
        damage = _dmg;
    }

    private void OnTriggerEnter2D(Collider2D _other) {
        IDamageable damageable = _other.GetComponent<IDamageable>();
        damageable.TakeDamage(damage);
    }

}