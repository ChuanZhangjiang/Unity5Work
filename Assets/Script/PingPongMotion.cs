using UnityEngine;
using System.Collections;

public class PingPongMotion : MonoBehaviour {

    private Transform ThisTransform = null;
    private Vector3 OrigPos = Vector3.zero;
    public Vector3 MoveAxes = Vector3.zero;
    public float Distance = 3.0f;

    void Awake() {
        ThisTransform = GetComponent<Transform>();
        OrigPos = ThisTransform.position;
    }

	// Use this for initialization
	void Start () {
        ThisTransform.position = OrigPos + MoveAxes * Mathf.PingPong(Time.time, Distance);
        OrigPos = ThisTransform.position;
    }
	
	// Update is called once per frame
	void Update () {
        ThisTransform.position = OrigPos + MoveAxes * Mathf.PingPong(Time.time, Distance);
    }
}
