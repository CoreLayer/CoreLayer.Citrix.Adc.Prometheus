using System.Collections.Generic;
using CoreLayer.Citrix.Adc.PrometheusMetrics.Interfaces;
using CoreLayer.Prometheus;

namespace CoreLayer.Citrix.Adc.PrometheusMetrics.Modules.System
{
    public class SystemMetrics : IModuleMetrics
    {
        public List<PrometheusMetric> Data { get; set; } = new List<PrometheusMetric>
        {
            new PrometheusMetric
            {
                Name = "voltagev12n",
                Description = "Power supply -12V output. Acceptable range is -13.20 through -10.80 volts. 9800 and 9960 platforms display standard value of -12.0V.",
                MetricType = PrometheusMetricType.Gauge,
                Label = "voltage12n"
            },
            new PrometheusMetric
            {
                Name = "voltagev5n",
                Description = "Power supply -5V output. Acceptable range is -5.50 through -4.50 volts. 9800 and 9960 platforms display standard value of -5.0V.",
                MetricType = PrometheusMetricType.Gauge,
                Label = "voltagev5n"
            },
            new PrometheusMetric
            {
                Name = "cpuusage",
                Description = "CPU utilization percentage.",
                MetricType = PrometheusMetricType.Gauge,
                Label = "cpuusage"
            },
            new PrometheusMetric
            {
                Name = "numcpus",
                Description = "The number of CPUs on the Citrix ADC.",
                MetricType = PrometheusMetricType.Counter,
                Label = "cpu_count"
            },
            
        };
    }
}