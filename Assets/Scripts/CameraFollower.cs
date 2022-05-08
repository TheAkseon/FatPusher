using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private Vector3 _offset;

    private void Update()
    {
        transform.position = _player.transform.position + _offset;
    }
}
