using System.Collections.Generic;
using CoreLayer.Prometheus;

namespace CoreLayer.Citrix.Adc.PrometheusMetrics.Modules.Basic
{
    public class ServicegroupMemberMetrics
    {
        public List<PrometheusMetric> Data { get; set; } = new List<PrometheusMetric>
        {
            new PrometheusMetric()
            {
                Name = "servicegroupname",
                Description = "Name of the servicegroup",
                MetricType = PrometheusMetricType.Label,
                Label = "servicegroupname"
            },
            new PrometheusMetric()
            {
                Name = "ip",
                Description = "IP address of the servicegroup. Mutually exclusive with server name.",
                MetricType = PrometheusMetricType.Label,
                Label = "ip"
            },
            new PrometheusMetric()
            {
                Name = "servername",
                Description = "Name of the server. Mutually exclusive with ip.",
                MetricType = PrometheusMetricType.Label,
                Label = "servername"
            },
            new PrometheusMetric()
            {
                Name = "port",
                Description = "Port number of the service group member.",
                MetricType = PrometheusMetricType.Label,
                Label = "port"
            },
            new PrometheusMetric()
            {
                Name = "avgsvrttfb",
                Description = "Average Time To First Byte between the netscaler appliance and the server.",
                MetricType = PrometheusMetricType.Gauge,
                Label = "avgsvrttfb"
            },
            new PrometheusMetric()
            {
                Name = "primaryipaddress",
                Description = "The Ip address on which the service is running.",
                MetricType = PrometheusMetricType.Label,
                Label = "primaryipaddress"
            },
            new PrometheusMetric()
            {
                Name = "primaryport",
                Description = "Port on which the service is running.",
                MetricType = PrometheusMetricType.Label,
                Label = "primaryport"
            },
            new PrometheusMetric()
            {
                Name = "servicetype",
                Description = "The service type of this service.",
                MetricType = PrometheusMetricType.Label,
                Label = "servicetype"
            },
            new PrometheusMetric()
            {
                Name = "state",
                Description = "The state of the server.",
                MetricType = PrometheusMetricType.Label,
                Label = "state"
            },
            new PrometheusMetric()
            {
                Name = "totalrequests",
                Description = "Total Number of requests received on this service.",
                MetricType = PrometheusMetricType.Counter,
                Label = "totalrequests"
            },
            new PrometheusMetric()
            {
                Name = "requestsrate",
                Description = "Rate counter for totalrequests (per second).",
                MetricType = PrometheusMetricType.Gauge,
                Label = "requestsrate"
            },
            new PrometheusMetric()
            {
                Name = "totalresponses",
                Description = "Total number of responses received on this service.",
                MetricType = PrometheusMetricType.Counter,
                Label = "totalresponses"
            },
            new PrometheusMetric()
            {
                Name = "responsesrate",
                Description = "Rate counter for totalresponses (per second).",
                MetricType = PrometheusMetricType.Gauge,
                Label = "responsesrate"
            },
            new PrometheusMetric()
            {
                Name = "totalrequestbytes",
                Description = "Total number of request bytes received by this service.",
                MetricType = PrometheusMetricType.Counter,
                Label = "totalrequestbytes"
            },
            new PrometheusMetric()
            {
                Name = "requestbytesrate",
                Description = "Rate counter for totalrequestbytes (per second).",
                MetricType = PrometheusMetricType.Gauge,
                Label = "requestbytesrate"
            },
            new PrometheusMetric()
            {
                Name = "totalresponsebytes",
                Description = "Number of response bytes received by this service.",
                MetricType = PrometheusMetricType.Counter,
                Label = "totalresponsebytes"
            },
            new PrometheusMetric()
            {
                Name = "responsebytesrate",
                Description = "Rate counter for totalresponsebytes (per second).",
                MetricType = PrometheusMetricType.Gauge,
                Label = "responsebytesrate"
            },
            new PrometheusMetric()
            {
                Name = "curclntconnections",
                Description = "Number of current client connections.",
                MetricType = PrometheusMetricType.Gauge,
                Label = "curclntconnections"
            },
            new PrometheusMetric()
            {
                Name = "surgecount",
                Description = "Number of requests in the surge queue.",
                MetricType = PrometheusMetricType.Gauge,
                Label = "surgecount"
            },
            new PrometheusMetric()
            {
                Name = "cursrvrconnections",
                Description = "Number of current connections to the actual servers behind the virtual server.",
                MetricType = PrometheusMetricType.Gauge,
                Label = "cursrvrconnections"
            },
            new PrometheusMetric()
            {
                Name = "svrestablishedconn",
                Description = "Number of connections in ESTABLISHED state.",
                MetricType = PrometheusMetricType.Gauge,
                Label = "svrestablishedconn"
            },
            new PrometheusMetric()
            {
                Name = "curreusepool",
                Description = "number of requests in the idle queue/reuse pool.",
                MetricType = PrometheusMetricType.Gauge,
                Label = "curreusepool"
            },
            new PrometheusMetric()
            {
                Name = "maxclients",
                Description = "Maximum open connections allowed on this service.",
                MetricType = PrometheusMetricType.Label,
                Label = "maxclients"
            },
            new PrometheusMetric()
            {
                Name = "totsvrttlbtransactions",
                Description = "Total transactions where server TTLB is calculated.",
                MetricType = PrometheusMetricType.Counter,
                Label = "totsvrttlbtransactions"
            },
            new PrometheusMetric()
            {
                Name = "toleratingttlbtransactions",
                Description = "Tolerable transactions based on APDEX threshold.",
                MetricType = PrometheusMetricType.Counter,
                Label = "toleratingttlbtransactions"
            },
            new PrometheusMetric()
            {
                Name = "frustratingttlbtransactions",
                Description = "Frustrating transactions based on APDEX threshold."
            }
        };
    }
}