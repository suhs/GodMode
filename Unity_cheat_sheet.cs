public class Enemy : MonoBehaviour {
    public GameObject player; // and attach player GameObject
    public Transform playerTransform; // and attach player GameObject, but only Transform object is being called

    void Start() {
        // Start the enemy ten units behind the player character.
        transform.position = player.transform.position - Vector3.forward * 10f;
    }
}


using UnityEngine;

public class WaypointManager : MonoBehaviour {
    public Transform[] waypoints;

    void Start() {
        waypoints = new Transform[transform.childCount];
        int i = 0;

        foreach (Transform t in transform) { // all GameObject has transform
            waypoints[i++] = t;
        }
        //alternatively do one of these
        transform.Find("Gun");
    }
}


GameObject player;
GameObject[] enemies;

void Start() {
    player = GameObject.Find("MainHeroCharacter"); // find by name, but for performance use FindWithTag
    player = GameObject.FindWithTag("Player"); // one instance
    enemies = GameObject.FindGameObjectsWithTag("Enemy"); // array
}


// calculate and move position
void Update() {
    float distance = speed * Time.deltaTime * Input.GetAxis("Horizontal");
    transform.Translate(Vector3.right * distance);
}
