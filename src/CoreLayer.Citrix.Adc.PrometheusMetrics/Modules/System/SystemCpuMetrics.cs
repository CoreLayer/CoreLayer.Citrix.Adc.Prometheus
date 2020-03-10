using System.Collections.Generic;
using CoreLayer.Prometheus;

namespace CoreLayer.Citrix.Adc.PrometheusMetrics.Modules.System
{
    public class SystemCpuMetrics
    {
        public List<PrometheusMetric> Data { get; set; } = new List<PrometheusMetric>
        {
            new PrometheusMetric
            {
                Name = "percpuuse",
                Description = "CPU utilization percentage.",
                MetricType = PrometheusMetricType.Gauge,
                Label = "percpuuse"
            }
        };
    }
}