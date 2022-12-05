using System.Collections.Generic;
using System.Collections;
using UnityEngine.Events;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class ColliderButton : MonoBehaviour
{
    public BoxCollider2D Collieder => _collider;

    [SerializeField] private bool _noEventsTriggered;
    public UnityEvent OnClick;

    private BoxCollider2D _collider;
    private Camera _mainCam;
    private Vector2 _clickedDownPosition;

    public void SetButtonState(bool active)
    {
        _collider.enabled = active;
    }

    private void Awake()
    {
        _collider = GetComponent<BoxCollider2D>();
        _mainCam = Camera.main;
    }

    private void Update()
    {
        Vector3 touchPos;
#if UNITY_EDITOR
        if (Input.GetMouseButtonDown(0))
        {
            touchPos = _mainCam.ScreenToWorldPoint(Input.mousePosition);

            if (_collider.OverlapPoint(touchPos))
                OnClickedDown(touchPos);

        }

        if (Input.GetMouseButtonUp(0))
        {
            touchPos = _mainCam.ScreenToWorldPoint(Input.mousePosition);


            if (_collider.OverlapPoint(touchPos))
                OnClickedUp(touchPos);
        }
#else
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            touchPos = _mainCam.ScreenToWorldPoint(touch.position);
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    if (_collider.OverlapPoint(touchPos)) OnClickedDown(touchPos);
                    break;
                case TouchPhase.Ended:
                case TouchPhase.Canceled:
                    if (_collider.OverlapPoint(touchPos)) OnClickedUp(touchPos);
                    break;
            } 
        }
#endif
    }

    private void OnClickedDown(Vector2 clickPos)
    {
        _clickedDownPosition = clickPos;
    }

    private void OnClickedUp(Vector2 clickPos)
    {
        if (Vector2.SqrMagnitude(_clickedDownPosition - clickPos) > 0.75f)
            return;

        OnClick?.Invoke();
    }
}
