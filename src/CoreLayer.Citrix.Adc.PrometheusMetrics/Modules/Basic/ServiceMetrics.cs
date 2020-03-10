using System.Collections.Generic;
using CoreLayer.Prometheus;

namespace CoreLayer.Citrix.Adc.PrometheusMetrics.Modules.Basic
{
    public class ServiceMetrics
    {
        public List<PrometheusMetric> Data = new List<PrometheusMetric>
        {
            new PrometheusMetric()
            {
                Name = "name",
                Description = "Name of the service.",
                MetricType = PrometheusMetricType.Label,
                Label = "name"
            },
            new PrometheusMetric()
            {
                Name = "throughput",
                Description = "Number of bytes received or sent by this service.",
                MetricType = PrometheusMetricType.Counter,
                Label = "throughput"
            },
            new PrometheusMetric()
            {
                Name = "throughputrate",
                Description = "Rate counter for throughput (per second).",
                MetricType = PrometheusMetricType.Gauge,
                Label = "throughputrate"
            },
            new PrometheusMetric()
            {
                Name = "avgsvrttfb",
                Description = "Average Time To First Byte between netscaler appliance and the server.",
                MetricType = PrometheusMetricType.Gauge,
                Label = "avgsvrttfb"
            },
            new PrometheusMetric()
            {
                Name = "primaryipaddress",
                Description = "Ip address on which the service is running.",
                MetricType = PrometheusMetricType.Label,
                Label = "primaryipaddress"
            },
            new PrometheusMetric()
            {
                Name = "primaryport",
                Description = "The port on which the service is running.",
                MetricType = PrometheusMetricType.Label,
                Label = "primaryport"
            },
            new PrometheusMetric()
            {
                Name = "servicetype",
                Description = "The type of service.",
                MetricType = PrometheusMetricType.Label,
                Label = "servicetype"
            },
            new PrometheusMetric()
            {
                Name = "state",
                Description = "Current state of the server.",
                MetricType = PrometheusMetricType.Label,
                Label = "state"
            },
            new PrometheusMetric()
            {
                Name = "totalrequests",
                Description = "Total number of requests received on this service.",
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
                Label = "reponsesrate"
            },
            new PrometheusMetric()
            {
                Name = "totalrequestbytes",
                Description = "Total number of request bytes received on this service.",
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
                Description = "Total number of response bytes received by this service.",
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
                Description = "Number of current connections to the server behind the virtual server.",
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
                Description = "Number of requests in the idle queue/reuse pool.",
                MetricType = PrometheusMetricType.Gauge,
                Label = "curreusepool"
            },
            new PrometheusMetric()
            {
                Name = "maxclients",
                Description = "Maximum open connections allowed on this client.",
                MetricType = PrometheusMetricType.Label,
                Label = "maxclients"
            },
            new PrometheusMetric()
            {
                Name = "curload",
                Description = "Load on the service that is calculated from the bound load based monitor.",
                MetricType = PrometheusMetricType.Gauge,
                Label = "curload"
            },
            new PrometheusMetric()
            {
                Name = "curtflags",
                Description = "Current flags on the service for internal use in displayhandlers.",
                MetricType = PrometheusMetricType.Gauge,
                Label = "curtflags"
            },
            new PrometheusMetric()
            {
                Name = "totsvrttlbtransations",
                Description = "Toal transactions where server TTLB is calculated.",
                MetricType = PrometheusMetricType.Counter,
                Label = "totsvrttlbtransactions"
            },
            new PrometheusMetric()
            {
                Name = "toleratingttlbtransactions",
                Description = "Tolerable Transactions based on APDEX threshold.",
                MetricType = PrometheusMetricType.Counter,
                Label = "toleratingttlbtransactions"
            },
            new PrometheusMetric()
            {
                Name = "frustratingttlbtransactions",
                Description = "Frustrating transactions based on APDEX threshold.",
                MetricType = PrometheusMetricType.Counter,
                Label = "frustratingttlbtrancactions"
            },
            new PrometheusMetric()
            {
                Name = "vsvrservicehits",
                Description = "Number of times the service has been provided.",
                MetricType = PrometheusMetricType.Counter,
                Label = "vsvrservicehits"
            },
            new PrometheusMetric()
            {
                Name = "vsvrservicehitsrate",
                Description = "Rate counter for vsvrservicehits (per second).",
                MetricType = PrometheusMetricType.Gauge,
                Label = "vsvrservicehitsrate"
            },
            new PrometheusMetric()
            {
                Name = "activetransactions",
                Description = "Number of active transactions handled by this service.",
                MetricType = PrometheusMetricType.Gauge,
                Label = "activetransactions"
            },
            new PrometheusMetric()
            {
                Name = "totalconnreassemblyqueue75",
                Description = "", //todo
                MetricType = PrometheusMetricType.Counter,
                Label = "totalconnreassemblyqueue75"
            },
            new PrometheusMetric()
            {
                Name = "totalconnreassemblyqueueflush",
                Description = "", //todo
                MetricType = PrometheusMetricType.Counter,
                Label = "totalconnreassemblyqueueflush"
            },
            new PrometheusMetric()
            {
                Name = "httpmaxhdrszpkts",
                Description = "", //todo
                MetricType = PrometheusMetricType.Counter,
                Label = "httpmaxhdrszpkts"
            },
            new PrometheusMetric()
            {
                Name = "tcpmaxooopkts",
                Description = "", //todo
                MetricType = PrometheusMetricType.Counter,
                Label = "tcpmaxooopkts"
            }
        };
    }
}