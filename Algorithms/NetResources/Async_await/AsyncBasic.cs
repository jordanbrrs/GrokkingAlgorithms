namespace NetResources.Async_await
{
    public class AsyncBasic
    {
        public async Task PrintMessage() {
            Console.WriteLine("First message");
            await Task.Delay(2000);
            Console.WriteLine("Second message");
        }
    }
}
