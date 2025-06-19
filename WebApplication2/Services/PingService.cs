using System.Net.NetworkInformation;

namespace WebApplication2.Services
{
    public class PingService
    {
        public async Task<(string status, double averageTime)> CheckPingStatusAsync(string ip)
        {
            int timeoutCount = 0;
            int highPingCount = 0;
            long totalPingTime = 0;
            int successCount = 0;

            using var ping = new Ping();

            for (int i = 0; i < 7; i++)
            {
                try
                {
                    var reply = await ping.SendPingAsync(ip, 1000);
                    if (reply.Status == IPStatus.Success)
                    {
                        totalPingTime += reply.RoundtripTime;
                        successCount++;

                        if (reply.RoundtripTime > 15)
                            highPingCount++;
                    }
                    else
                    {
                        timeoutCount++;
                    }
                }
                catch
                {
                    timeoutCount++;
                }

                await Task.Delay(100);
            }

            if (timeoutCount >= 5)
                return ("Connection Lost", -1);

            if (highPingCount >= 3)
                return ("High Ping", totalPingTime / successCount);

            return ("Good", totalPingTime / successCount);
        }
    }
}
