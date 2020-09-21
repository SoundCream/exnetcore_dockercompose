namespace Arm.NetcoreCompose.Models
{
    public class HealthCheckModel
    {
        public string RuntimeVersion { get; set; }

        public string OSDescription { get; set; }

        public bool IsContainerized { get; set; }

        public int CPUCores { get; set; }

        public string CGroupMemoryUsage { get; set; }

        public long MemoryCurrentUsage { get; set; }

        public long MemoryMaxAvailable { get; set; }
    }
}
