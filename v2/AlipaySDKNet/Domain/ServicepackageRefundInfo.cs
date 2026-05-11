using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ServicepackageRefundInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ServicepackageRefundInfo : AopObject
    {
        /// <summary>
        /// 退款发起角色: 1-用户主动发起 2-运营 3-医生拒单 41-医生超时未接单 42-服务包过期
        /// </summary>
        [XmlElement("operator_role")]
        public long OperatorRole { get; set; }

        /// <summary>
        /// 退款金额(单位分)
        /// </summary>
        [XmlElement("refund_amount")]
        public long RefundAmount { get; set; }

        /// <summary>
        /// 退款状态: 23-退款中 32-已完成退款 33-部分退款 45-退款失败
        /// </summary>
        [XmlElement("refund_status")]
        public long RefundStatus { get; set; }
    }
}
