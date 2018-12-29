using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class AutoDestroy : MonoBehaviour
{
    bool _enabled = false;
    Renderer _renderer;
    public player playerr;
    void Start()
    {
        _renderer = GetComponent<Renderer>();
    }
    void Update()
    {
        if (!_enabled && _renderer.isVisible)
            _enabled = true;
        if (_enabled && !_renderer.isVisible)
        {
            Destroy(gameObject);
            playerr.taman -= 1;
        }
    }
}
