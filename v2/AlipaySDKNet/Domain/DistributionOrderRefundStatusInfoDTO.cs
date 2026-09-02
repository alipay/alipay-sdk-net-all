using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DistributionOrderRefundStatusInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class DistributionOrderRefundStatusInfoDTO : AopObject
    {
        /// <summary>
        /// 退款单状态
        /// </summary>
        [XmlElement("refund_status")]
        public string RefundStatus { get; set; }
    }
}
