// Create a prefab
// upload a sprite, and then slice it
// drag to a prefab
// rename animation before dragging. Use animation controller to switch between



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

void Start() { // Start runs before the first frame or physics update on an object
    player = GameObject.Find("MainHeroCharacter"); // find by name, but for performance use FindWithTag
    player = GameObject.FindWithTag("Player"); // one instance
    enemies = GameObject.FindGameObjectsWithTag("Enemy"); // array
}


// calculate and move position
void Update() { // Update updates at its own pace
    float distance = speed * Time.deltaTime * Input.GetAxis("Horizontal"); // times by deltaTime to scale the size of the movement by the frame time
    transform.Translate(Vector3.right * distance);
}

// add force to the body
void FixedUpdate() { // FixedUpdate updates at the same frequency as physics updates
    Vector3 force = transform.forward * driveForce * Input.GetAxis("Vertical");
    rigidbody.AddForce(force);
}

void LateUpdate() { // LateUpdate runs after Update and FixedUpdate. Use this to adjust camera, animation based on updated physics
    Camera.main.transform.LookAt(target.transform);
}

void Awake() // called when a scene the object is in is loaded, BEFORE Start function is called


using UnityEngine;
using System.Collections;

public class ExampleClass : MonoBehaviour {
  //for GUI events. ie. OnMouseOver, OnMouseDown
    void OnGUI() {
        if (GUI.Button(new Rect(10, 10, 150, 100), "I am a button"))
            print("You clicked the button!");

    }
}


/*
OnCollisionEnter, OnCollisionStay and OnCollisionExit functions will be called as contact is made, held and broken.
OnTriggerEnter, OnTriggerStay and OnTriggerExit functions will be called when the object’s collider is configured as a Trigger
(ie, a collider that simply detects when something enters it rather than reacting physically).
*/
void OnCollisionEnter(otherObj: Collision) {
    if (otherObj.tag == "Arrow") {
        ApplyDamage(10);
    }
}
