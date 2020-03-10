using System.Collections.Generic;
using CoreLayer.Prometheus;

namespace CoreLayer.Citrix.Adc.PrometheusMetrics.Modules.ContentSwitching
{
    public class CsvserverMetrics
    {
        public List<PrometheusMetric> Data { get; set; } = new List<PrometheusMetric>()
        {
            new PrometheusMetric()
            {
                Name = "Name",
                Description = "Name of the content switching virtual server.",
                MetricType = PrometheusMetricType.Label,
                Label = "name"
            },
            new PrometheusMetric()
            {
                Name = "avgcltttlb",
                Description = "Average time to last byte between the client and the server.",
                MetricType = PrometheusMetricType.Gauge,
                Label = "avgcltttlb"
            },
            new PrometheusMetric()
            {
                Name = "cltresponsetimeapdex",
                Description = "Virtual server APDEX index based on client response times.",
                MetricType = PrometheusMetricType.Gauge,
                Label = "cltresponsetimeapdex"
            },
            new PrometheusMetric()
            {
                Name = "establishedconn",
                Description = "number of client connections in ESTABLISHED state.",
                MetricType = PrometheusMetricType.Gauge,
                Label = "establishedconn"
            },
            new PrometheusMetric()
            {
                Name = "primaryipaddress",
                Description = "IP address of the virtual server.",
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
                Name = "type",
                Description = "Protocol associated with the virtual server.",
                MetricType = PrometheusMetricType.Label,
                Label = "type"
            },
            new PrometheusMetric()
            {
                Name = "state",
                Description = "Current state of the virtual server.",
                MetricType = PrometheusMetricType.Label,
                Label = "state"
            },
            new PrometheusMetric()
            {
                Name = "tothits",
                Description = "Total hits on the virtual server",
                MetricType = PrometheusMetricType.Counter,
                Label = "tothits"
            },
            new PrometheusMetric()
            {
                Name = "hitsrate",
                Description = "Rate counter for tothits.(per second)",
                MetricType = PrometheusMetricType.Gauge,
                Label = "tothitsrate"
            },
            new PrometheusMetric()
            {
                Name = "totalrequests",
                Description = "Total number of requests on this virtual server",
                MetricType = PrometheusMetricType.Counter,
                Label = "totalrequests"
            },
            new PrometheusMetric()
            {
                Name = "requestsrate",
                Description = "Rate counter for totalrequests. (per second)",
                MetricType = PrometheusMetricType.Gauge,
                Label = "requestsrate"
            },
            new PrometheusMetric()
            {
                Name = "totalresponses",
                Description = "Total number of responses received on this virtual server.",
                MetricType = PrometheusMetricType.Counter,
                Label = "totalresponses"
            },
            new PrometheusMetric()
            {
                Name = "responsesrate",
                Description = "Rate counter for totalresponses.",
                MetricType = PrometheusMetricType.Gauge,
                Label = "responsesrate"
            },
            new PrometheusMetric()
            {
                Name = "totalrequestbytes",
                Description = "Total number of request bytes received on this virtual server.",
                MetricType = PrometheusMetricType.Counter,
                Label = "totalrequestbytes"
            },
            new PrometheusMetric()
            {
                Name = "requestbytesrate",
                Description = "Rate counter for totalrequestbytes.",
                MetricType = PrometheusMetricType.Gauge,
                Label = "requestbytesrate"
            },
            new PrometheusMetric()
            {
                Name = "totalresponsebytes",
                Description = "Total number of response bytes received by this virtual server.",
                MetricType = PrometheusMetricType.Counter,
                Label = "totalresponsebytes"
            },
            new PrometheusMetric()
            {
                Name = "responsebytesrate",
                Description = "Rate counter for totalresponsebytes.",
                MetricType = PrometheusMetricType.Gauge,
                Label = "responsebytesrate"
            },
            new PrometheusMetric()
            {
                Name = "totalpktsrecvd",
                Description = "Total number of packets received by this virtual server.",
                MetricType = PrometheusMetricType.Counter,
                Label = "totalpktsrecvd"
            },
            new PrometheusMetric()
            {
                Name = "pktsrecvdrate",
                Description = "Rate counter for totalpktsrecvd. (per second)",
                MetricType = PrometheusMetricType.Gauge,
                Label = "pktsrecvdrate"
            },
            new PrometheusMetric()
            {
                Name = "totalpktssent",
                Description = "Total number of packets sent.",
                MetricType = PrometheusMetricType.Counter,
                Label = "totalpktssent"
            },
            new PrometheusMetric()
            {
                Name = "pktssentrate",
                Description = "Rate counter for totalpktssent. (per second)",
                MetricType = PrometheusMetricType.Gauge,
                Label = "pktssentrate"
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
                Name = "cursrvrconnections",
                Description = "Number of current connections to the actual server behind the virtual server.",
                MetricType = PrometheusMetricType.Gauge,
                Label = "labelcursrvrconnections"
            },
            new PrometheusMetric()
            {
                Name = "sothreshold",
                Description = "Spillover threshold set on the virtual server.",
                MetricType = PrometheusMetricType.Label,
                Label = "sothreshold"
            },
            new PrometheusMetric()
            {
                Name = "totspillovers",
                Description = "number of times the virtual server experienced spillover.",
                MetricType = PrometheusMetricType.Counter,
                Label = "totspillovers"
            },
            new PrometheusMetric()
            {
                Name = "labelledconn",
                Description = "Number of labelled connections on this virtual server.",
                MetricType = PrometheusMetricType.Gauge,
                Label = "labelledconn"
            },
            new PrometheusMetric()
            {
                Name = "pushlabel",
                Description = "number of labels for this push server.",
                MetricType = PrometheusMetricType.Gauge,
                Label = "pushlabel"
            },
            new PrometheusMetric()
            {
                Name = "deferredreq",
                Description = "Number of deferred requests on this virtual server",
                MetricType = PrometheusMetricType.Counter,
                Label = "deferredreq"
            },
            new PrometheusMetric()
            {
                Name = "deferredreqrate",
                Description = "Rate counter for deferredreq. (per second)",
                MetricType = PrometheusMetricType.Gauge,
                Label = "deferredreqrate"
            },
            new PrometheusMetric()
            {
                Name = "invalidrequestresponse",
                Description = "Number of invalid requests/responses on this virtual server.",
                MetricType = PrometheusMetricType.Counter,
                Label = "invalidrequestresponse"
            },
            new PrometheusMetric()
            {
                Name = "invalidrequestresponsedropped",
                Description = "Number of invalid requests/responses dropped on this virtual server.",
                MetricType = PrometheusMetricType.Counter,
                Label = "invalidrequestresponsedropped"
            },
            new PrometheusMetric()
            {
                Name = "totvserverdownbackuphits",
                Description = "Number of times traffic was diverted to backup virtual server since primary was DOWN.",
                MetricType = PrometheusMetricType.Counter,
                Label = "totvserverdownbackuphits"
            },
            new PrometheusMetric()
            {
                Name = "curmptcpsessions",
                Description = "Current Multipath Tcp sessions.",
                MetricType = PrometheusMetricType.Gauge,
                Label = "curmptcpsessions"
            },
            new PrometheusMetric()
            {
                Name = "cursubflowconn",
                Description = "Current multipath TCP subflows.",
                MetricType = PrometheusMetricType.Gauge,
                Label = "cursubflowconn"
            },
            new PrometheusMetric()
            {
                Name = "totcltttlbtransactions",
                Description = "Total transactions where client TTLB is calculated.",
                MetricType = PrometheusMetricType.Counter,
                Label = "totcltttlbtransactions"
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
                Name = "toleratingttlbtransactionsrate",
                Description = "Rate counter for toleratingttlbtransactions.",
                MetricType = PrometheusMetricType.Gauge,
                Label = "toleratingttlbtransactions"
            },
            new PrometheusMetric()
            {
                Name = "frustratingttlbtransactions",
                Description = "Frustrating transactions based on APDEX treshold.",
                MetricType = PrometheusMetricType.Counter,
                Label = "frustratingttlbtransactions"
            },
            new PrometheusMetric()
            {
                Name = "frustratingttlbtransactionsrate",
                Description = "Rate counter for frustratingttlbtransactions.",
                MetricType = PrometheusMetricType.Gauge,
                Label = "frustratingttlbtransactionsrate"
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