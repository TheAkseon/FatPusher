using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private Vector2Int _destroyPriceRange;
    [SerializeField] private TMP_Text _view;

    private int _destroyPrice;
    private int _eating;
    private int _leftToEat;

    private void Start()
    {
        _destroyPrice = Random.Range(_destroyPriceRange.x, _destroyPriceRange.y);
        _leftToEat = _destroyPrice;
        _view.text = _leftToEat.ToString();
    }

    public void Eat()
    {
        _eating++;
        _leftToEat--;
        _view.text = _leftToEat.ToString();

        if (_eating == _destroyPrice)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Eat();
        }
    }
}
