using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Characters.ThirdPerson;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour
{
    public NavMeshAgent enemyAgent;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        enemyAgent.updateRotation = false;
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        enemyAgent.SetDestination(player.transform.position);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == player)
        {
            InfoTracker.lives--;
            if (InfoTracker.score >= InfoTracker.bestRoundScore)
            {
                InfoTracker.bestRoundScore = InfoTracker.score;
            }
            InfoTracker.score = 0;

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
