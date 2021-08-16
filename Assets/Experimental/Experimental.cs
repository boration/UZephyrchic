using UnityEngine;

public class Experimental : MonoBehaviour
{
    [SerializeField] private float speed = 20;
    [SerializeField] private float range = 1;
    private Vector2 _goal;

    private void Update()
    {
        float speedDelta = speed * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, _goal, speedDelta);

        if ((Vector2)transform.position == _goal)
        {
            _goal = ChooseNewGoal();
        }
    }

    private Vector2 ChooseNewGoal()
    {
        return Random.insideUnitCircle * range;
    }
}
