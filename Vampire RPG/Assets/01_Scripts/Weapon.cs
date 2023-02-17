using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    [SerializeField]
    private GameObject swoosh;

    [SerializeField]
    private int attackDamage;
    [SerializeField]
    private float attackDuration;
    [SerializeField]
    private float attackRange;

    public void OnStart() {
        swoosh.GetComponent<Hitbox>().Initialize(attackDamage);
    }

    public void OnUpdate() {
        if(Input.GetMouseButtonDown(0)) {

            Vector3 mouseDir = InputManager.MousePosition - transform.position;
            mouseDir.Normalize();
            float rot = Mathf.Atan2(mouseDir.y, mouseDir.x) * Mathf.Rad2Deg;

            StartCoroutine(Attack(mouseDir, rot));

        }
    }

    private IEnumerator Attack(Vector3 _dir, float _rot) {

        swoosh.transform.position = transform.position + _dir * attackRange;
        swoosh.transform.rotation = Quaternion.Euler(new Vector3(0, 0, _rot + 90));

        swoosh.SetActive(true);
        
        yield return new WaitForSeconds(attackDuration);

        swoosh.SetActive(false);

    }

}
