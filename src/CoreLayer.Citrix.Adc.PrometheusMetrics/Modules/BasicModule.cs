using CoreLayer.Citrix.Adc.PrometheusMetrics.Modules.Basic;

namespace CoreLayer.Citrix.Adc.PrometheusMetrics.Modules
{
    public class BasicModule
    {
        public ServiceMetrics Service { get; set; }
        public ServicegroupMetrics Servicegroup { get; set; }
        public ServicegroupMemberMetrics ServicegroupMember { get; set; }
    }
}