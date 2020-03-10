using CoreLayer.Citrix.Adc.PrometheusMetrics.Modules.System;

namespace CoreLayer.Citrix.Adc.PrometheusMetrics.Modules
{
    public class SystemModule
    {
        public SystemMetrics System { get; set; }
        public SystemCpuMetrics SystemCpu { get; set; }
    }
}