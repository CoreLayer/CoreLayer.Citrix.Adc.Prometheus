using System.Collections.Generic;
using CoreLayer.Prometheus;

namespace CoreLayer.Citrix.Adc.PrometheusMetrics.Interfaces
{
    public interface IModuleMetrics
    {
        List<PrometheusMetric> Data { get; set; }
    }
}