using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Attack", menuName = "Attack")]
public class Attack : ScriptableObject
{
    public bool isEnemyInRange;
    public int turnSpeed;

    /*public void attackEnemy(Transform enemytoAttack)
    {
        Vector3 targetDirection = enemytoAttack.position - transform.position;

        Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, turnSpeed*Time.deltaTime, 0.0f);

        transform.rotation = Quaternion.LookRotation(newDirection);
    }*/
}
