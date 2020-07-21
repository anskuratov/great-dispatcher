using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class ChangeColorComponent : MonoBehaviour,
    IMessageListener<ChangeColor>
{
    private Renderer _renderer;

    private void Start()
    {
        _renderer = GetComponent<Renderer>();
    }

    public void OnMessage(ChangeColor message)
    {
        _renderer.material.SetColor("_Color", message.Color);
    }
}