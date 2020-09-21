using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using Arm.NetcoreCompose.Models;
using Microsoft.AspNetCore.Mvc;

namespace Arm.NetcoreCompose.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthCheckController : ControllerBase
    {

        [HttpGet]
        public IActionResult HealthCheck()
        {
            var process = Process.GetCurrentProcess();
            var result = new HealthCheckModel()
            {
                OSDescription = $"{RuntimeInformation.OSDescription} ({RuntimeInformation.OSArchitecture})",
                RuntimeVersion = RuntimeInformation.FrameworkDescription,
                IsContainerized = Environment.GetEnvironmentVariable("DOTNET_RUNNING_IN_CONTAINER") is object ? true : false,
                CPUCores = Environment.ProcessorCount,
                MemoryCurrentUsage = process.WorkingSet64,
                MemoryMaxAvailable = (long)process.MaxWorkingSet,
                CGroupMemoryUsage = (RuntimeInformation.OSDescription.StartsWith("Linux") && Directory.Exists("/sys/fs/cgroup/memory")) ?
                    System.IO.File.ReadAllLines("/sys/fs/cgroup/memory/memory.usage_in_bytes")[0] : string.Empty
            };

            return new JsonResult(result);
        }
    }
}
