using UnityEngine;

public class Shoting : MonoBehaviour
{
    [SerializeField] private float _nextShot;

    [SerializeField] private float _bulletDestroyTime;

    [SerializeField] private GameObject _bulletPrefab;

    private float _countDown = 0f;

    private void Update()
    {
        _countDown += Time.deltaTime;

        if (_countDown >= _nextShot)
        {
            GameObject bullet = Instantiate(_bulletPrefab, transform.position, Quaternion.identity);
            Destroy(bullet, _bulletDestroyTime);
            _countDown = 0f;
        }
    }
}
