using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] private Text _forceText;

    [SerializeField] private GameObject _gamePanel;
    [SerializeField] private GameObject _losePanel;

    private float _force = 1f;

    private void Start()
    {
        _forceText.text = _force.ToString();
    }

    private void Update()
    {
        if (_force <= 0f)
        {
            _gamePanel.SetActive(false);
            _losePanel.SetActive(true);
            Time.timeScale = 0;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Food"))
        {
            _force += 1;
            _forceText.text = _force.ToString();
            Destroy(other.gameObject);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            _force -= 1;
            _forceText.text = _force.ToString();
        }
    }
}
