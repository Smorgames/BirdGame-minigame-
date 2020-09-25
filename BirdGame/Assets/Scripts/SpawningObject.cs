using UnityEngine;

public class SpawningObject : MonoBehaviour
{
    [SerializeField] private Transform _target;

    [SerializeField] private Transform _topLimit;
    [SerializeField] private Transform _botLimit;

    private void OnEnable()
    {
        _target.position = new Vector3(_target.position.x, Random.Range(_botLimit.position.y, _topLimit.position.y), _target.position.z);
    }
}
