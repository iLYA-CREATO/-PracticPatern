internal interface IObserver
{
    /// <summary>
    /// Этот метод нужен для уведомления навблюдателей 
    /// </summary>
    void OnNotify();
}