using UnityEngine;
using UnityEngine.AI;

public class EnemyController
{
    public EnemyController(EnemyModel enemyModel, EnemyView enemyView)
    {
        EnemyModel = enemyModel;
        EnemyView = enemyView;
        EnemyView.EnemyController = this;
    }

    public EnemyModel EnemyModel { get; }
    public EnemyView EnemyView { get; }

    public void EnemyFollow(NavMeshAgent enemy, Transform player)
    {
        enemy.SetDestination(player.position);
    }
}
