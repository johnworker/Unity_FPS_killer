using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster_Control : MonoBehaviour
{
    public Transform target;
    public Animator anim;

    private UnityEngine.AI.NavMeshAgent _name;
    // Start is called before the first frame update
    void Start()
    {
        this._name = this.GetComponent<UnityEngine.AI.NavMeshAgent>();
        this.anim.PlayInFixedTime("Walk", 0, Random.Range(0.0f, 1.0f));
    }

    // Update is called once per frame
    void Update()
    {
        if (this._name.enabled)
        {
            this._name.SetDestination(this.target.position);
        }
    }
}
