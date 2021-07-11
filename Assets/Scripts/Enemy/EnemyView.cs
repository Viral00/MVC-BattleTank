using UnityEngine;
using UnityEngine.AI;

public class EnemyView : MonoBehaviour
{
    public Transform Player;
    public NavMeshAgent enemy;
    public EnemyController EnemyController;

    public EnemyView(EnemyController enemyController)
    {
        EnemyController = enemyController;
    }

    private void Update()
    {
        EnemyController.EnemyFollow(enemy, Player);
    }

}
