using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DistributionOrderStatusInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class DistributionOrderStatusInfoDTO : AopObject
    {
        /// <summary>
        /// 订单关闭原因
        /// </summary>
        [XmlElement("close_reason")]
        public string CloseReason { get; set; }

        /// <summary>
        /// 变更前状态
        /// </summary>
        [XmlElement("source_status")]
        public string SourceStatus { get; set; }

        /// <summary>
        /// 变更后状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
