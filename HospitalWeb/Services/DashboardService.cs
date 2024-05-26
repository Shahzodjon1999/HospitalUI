namespace HospitalWeb.Services;
public class DashboardService
{
    // Simulate fetching data from an API or database
    public Task<int> GetTotalPatientsAsync()
    {
        return Task.FromResult(123); // Example data
    }

    public Task<int> GetTotalAppointmentsAsync()
    {
        return Task.FromResult(456); // Example data
    }

    public Task<int> GetTotalDoctorsAsync()
    {
        return Task.FromResult(78); // Example data
    }
}
