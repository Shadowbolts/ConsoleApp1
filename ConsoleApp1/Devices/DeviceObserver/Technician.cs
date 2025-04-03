namespace ConsoleApp1.Devices.DeviceObserver
{
    public class Technician : IObserver<string>
    {
        private List<IDisposable> subscriptions = new List<IDisposable>();
        public void Subscribe(params IObservable<string>[] devices)
        {
            foreach (var device in devices)
            {
                subscriptions.Add(device.Subscribe(this));
            }
        }
        public void OnNext(string value)
        {
            Console.WriteLine($"Технік отримав повідомлення: {value}");
            Console.ReadLine();
        }
        public void OnError(Exception error)
        {
            Console.WriteLine($"Помилка даних");
        }
        public void OnCompleted()
        {
            Console.WriteLine($"Повідомлення завершені.");
        }
        public void UnsubscribeAll()
        {
            foreach (var subscription in subscriptions)
            {
                subscription.Dispose();
            }
            subscriptions.Clear();
        }
    }
}
