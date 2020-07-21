public interface IMessageListener<T>
    where T : struct
{
    void OnMessage(T message);
}
