using UnityEngine;
using UnityEngine.UI;

public class ChangeColorButtonBehaviour : MonoBehaviour
{
    [SerializeField]
    private Button _button;

    [SerializeField]
    private Color _color;

    [SerializeField]
    private ChangeColorComponent[] _listenerComponents;

    private MessageDispatcher _dispatcher;

    private void Start()
    {
        _dispatcher = new MessageDispatcher();

        foreach(var component in _listenerComponents)
        {
            _dispatcher.AddListener<ChangeColor>(component);
        }

        _button.onClick.AddListener(ChangeColor);
    }

    private void ChangeColor()
    {
        _dispatcher.Dispatch(new ChangeColor(_color));
    }
}
