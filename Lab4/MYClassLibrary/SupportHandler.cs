namespace MYClassLibrary
{
    // Базовий клас для обробників запитів
    public abstract class SupportHandler
    {
        protected SupportHandler NextHandler;

    public void SetNextHandler(SupportHandler handler)
    {
        NextHandler = handler;
    }

    public abstract void HandleRequest(int level);
    }
}
