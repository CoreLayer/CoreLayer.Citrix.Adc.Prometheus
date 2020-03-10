using System.Collections.Generic;
using CoreLayer.Prometheus;

namespace CoreLayer.Citrix.Adc.PrometheusMetrics.Modules.LoadBalancing
{
    public class LbvserverMetrics
    {
        public List<PrometheusMetric> Data { get; set; } = new List<PrometheusMetric>
        {
            new PrometheusMetric()
            {
                Name = "name",
                Description = "Name of the virtual server.",
                Label = "name",
                MetricType = PrometheusMetricType.Label

            }, new PrometheusMetric()
            {
                Name = "avgctlttlb",
                Description = "Average Time To Last Byte between client and server.",
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
                Name = "vsvrsurgecount",
                Description = "Number of requests waiting on this virtual server.",
                MetricType = PrometheusMetricType.Gauge,
                Label = "vsvrsurgecount"
            },
            new PrometheusMetric()
            {
                Name = "establishedconn",
                Description = "Number of client connections in ESTABLISHED state.",
                MetricType = PrometheusMetricType.Gauge,
                Label = "establishedconn"
            },
            new PrometheusMetric()
            {
                Name = "inactsvcs",
                Description = "Number of INACTIVE services bound to virtual server.",
                MetricType = PrometheusMetricType.Gauge,
                Label = "aniactsvcs"
            }, 
            new PrometheusMetric()
            {
                Name = "vslbhealth",
                Description = "Health of the virtual server. Gives the percentage of UP services bound to it.",
                MetricType = PrometheusMetricType.Gauge,
                Label = "vslbhealth"
            },
            new PrometheusMetric()
            {
                Name = "primaryipaddress",
                Description = "IP address of the virtual server",
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
                Name = "type",
                Description = "Protocol associated with the virtual server.",
                MetricType = PrometheusMetricType.Label,
                Label = "type"
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
                Name = "actsvcs",
                Description = "Number of active services bound to the virtual server.",
                MetricType = PrometheusMetricType.Gauge,
                Label = "actsvcs"
            },
            new PrometheusMetric()
            {
                Name = "tothits",
                Description = "Total virtual server hits.",
                MetricType = PrometheusMetricType.Counter,
                Label = "tothits"
            },
            new PrometheusMetric()
            {
                Name = "hitsrate",
                Description = "Rate (per second) counter for tothits.",
                MetricType = PrometheusMetricType.Gauge,
                Label = "hitsrate"
            },
            new PrometheusMetric()
            {
                Name = "totalrequests",
                Description = "The total number of requests received on this service or virtual server.",
                MetricType = PrometheusMetricType.Counter,
                Label = "totalrequests"
            },
            new PrometheusMetric()
            {
                Name = "requestsrate",
                Description = "Rate counter for totalrequests.(per second)",
                MetricType = PrometheusMetricType.Gauge,
                Label = "requestsrate"
            },
            new PrometheusMetric()
            {
                Name = "totalresponses",
                Description = "Number of responses received on this virtual server.",
                MetricType = PrometheusMetricType.Counter,
                Label = "totalresponses"
            },
            new PrometheusMetric()
            {
                Name = "responsesrate",
                Description = "Rate counter for totalresponses. (per second)",
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
                Description = "Rate counter for totalrequestbytes. (per second)",
                MetricType = PrometheusMetricType.Gauge,
                Label = "requestbytesrate"
            },
            new PrometheusMetric()
            {
                Name = "totalreponsebytes",
                Description = "Total number of response bytes received on this virtual server.",
                MetricType = PrometheusMetricType.Counter,
                Label = "totalresponsebytes"
            },
            new PrometheusMetric()
            {
                Name = "responsebytesrate",
                Description = "rate counter for totalresponsebytes. (per second)",
                MetricType = PrometheusMetricType.Gauge,
                Label = "responsebytesrate"
            },
            new PrometheusMetric()
            {
                Name = "totalpktsrecvd",
                Description = "Total amount of packets received by this virtual server",
                MetricType = PrometheusMetricType.Counter,
                Label = "totalpktsrecvd"
            },
            new PrometheusMetric()
            {
                Name = "pktsrecvdrate",
                Description = "Rate counter for totalpktsrecvd.(per second)",
                MetricType = PrometheusMetricType.Gauge,
                Label = "pktsrecvdrate"
            },
            new PrometheusMetric()
            {
                Name = "totalpktssent",
                Description = "Total amount of packets sent.",
                MetricType = PrometheusMetricType.Counter,
                Label = "totalpktssent"
            },
            new PrometheusMetric()
            {
                Name = "pktssentrate",
                Description = "Rate counter for totalpktssent.(per second)",
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
                Label = "cursrvrconnections"
            },
            new PrometheusMetric()
            {
                Name = "curpersistencesessions",
                Description = "current virtual server owned persistence sessions.",
                MetricType = PrometheusMetricType.Gauge,
                Label = "curpersistencesessions"
            },
            new PrometheusMetric()
            {
                Name = "curbackuppersistencesessions",
                Description = "Current virtal server owned backup persistence sessions.",
                MetricType = PrometheusMetricType.Gauge,
                Label = "curbackuppersistencesessions"
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
                Name = "svdsurgecount",
                Description = "Total number in the surge queues of all the services bound to this lbvserver.",
                MetricType = PrometheusMetricType.Gauge,
                Label = "svcsurgecount"
            },
            new PrometheusMetric()
            {
                Name = "sothreshold",
                Description = "Spill-over threshold set on the virtual server.",
                MetricType = PrometheusMetricType.Label,
                Label = "sothreshold"
            },
            new PrometheusMetric()
            {
                Name = "totspillovers",
                Description = "Number of times the virtual server experienced spillover.",
                MetricType = PrometheusMetricType.Counter,
                Label = "totspillovers"
            },
            new PrometheusMetric()
            {
                Name = "labelledconn",
                Description = "Number of labelled connections on the server",
                MetricType = PrometheusMetricType.Gauge,
                Label = "labelledconn"
            },
            new PrometheusMetric()
            {
                Name = "pushlabels",
                Description = "number of labels for this push virtual server.",
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
                Description = "rate counter for deferredreq. (per second)",
                MetricType = PrometheusMetricType.Gauge,
                Label = "deferredreqrate"
            },
            new PrometheusMetric()
            {
                Name = "invalidrequestresponse",
                Description = "number of invalid requests/responses on this virtual server.",
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
                Description = "number of times the traffic was diverted to the backup server since primary was DOWN.",
                MetricType = PrometheusMetricType.Counter,
                Label = "totserverdownbackuphits"
            },
            new PrometheusMetric()
            {
                Name = "curmptcvpsessions",
                Description = "Current multipath TCP sessions",
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
                Description = "Tolerable transactions bases on APDEX threshold.",
                MetricType = PrometheusMetricType.Counter,
                Label = "toleratingttlbtransactions"
            },
            new PrometheusMetric()
            {
                Name = "toleratingttlbtransactionsrate",
                Description = "Rate counter for toleratingttlbtransactions.",
                MetricType = PrometheusMetricType.Gauge,
                Label = "toleratingttlbtransactionsrate"
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
                Name = "frustringttlbtransactionsrate",
                Description = "Rate counter for frustratingttlbtransactions",
                MetricType = PrometheusMetricType.Gauge,
                Label = "frustratingttlbtransactionsrate"
            },
            new PrometheusMetric()
            {
                Name = "totalconnreasseblyqueue75",
                Description = "",//todo
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
                Name = "totalsvrbusyerr",
                Description = "", //todo
                MetricType = PrometheusMetricType.Counter,
                Label = "totalsvrbusyerr"
            },
            new PrometheusMetric()
            {
                Name = "svrbusyerrrate",
                Description = "Rate counter for totalsvrbusyerr",
                MetricType = PrometheusMetricType.Gauge,
                Label = "svrbusyerrrate"
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