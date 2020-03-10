using System.Collections.Generic;
using CoreLayer.Prometheus;

namespace CoreLayer.Citrix.Adc.PrometheusMetrics.Modules.Basic
{
    public class ServicegroupMetrics
    {
        public List<PrometheusMetric> Data { get; set; } = new List<PrometheusMetric>
        {
            new PrometheusMetric()
            {
                Name = "servicegroupname",
                Description = "The name of the servicegroup.",
                MetricType = PrometheusMetricType.Label,
                Label = "servicegroupname"
            },
            new PrometheusMetric()
            {
                Name = "servicetype",
                Description = "The type of the servicegroup.",
                MetricType = PrometheusMetricType.Label,
                Label = "servicetype"
            },
            new PrometheusMetric()
            {
                Name = "state",
                Description = "The current state of the servicegroup.",
                MetricType = PrometheusMetricType.Label,
                Label = "state"
            }
        };
    }
}