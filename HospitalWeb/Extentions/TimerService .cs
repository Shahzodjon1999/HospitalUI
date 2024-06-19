namespace HospitalWeb.Extentions;

public class TimerService : IAsyncDisposable
{
    private Timer? _timer;

    public event Func<Task>? OnElapsed;

    public void Start(TimeSpan interval)
    {
        _timer = new Timer(async _ =>
        {
            if (OnElapsed != null)
            {
                await OnElapsed.Invoke();
            }
        }, null, TimeSpan.Zero, interval);
    }

    public async ValueTask DisposeAsync()
    {
        if (_timer != null)
        {
            await _timer.DisposeAsync();
        }
    }
}
