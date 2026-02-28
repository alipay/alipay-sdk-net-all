using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ServiceUsedMetric Data Structure.
    /// </summary>
    [Serializable]
    public class ServiceUsedMetric : AopObject
    {
        /// <summary>
        /// 服务名称
        /// </summary>
        [XmlElement("service_name")]
        public string ServiceName { get; set; }

        /// <summary>
        /// 服务使用用户人数
        /// </summary>
        [XmlElement("service_used_cnt")]
        public long ServiceUsedCnt { get; set; }
    }
}
