using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpAssistantMembershippackageReverseModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpAssistantMembershippackageReverseModel : AopObject
    {
        /// <summary>
        /// 渠道创建权益包时关联的原始订单号，退权益仅支持已整个订单维度操作
        /// </summary>
        [XmlElement("origin_order_no")]
        public string OriginOrderNo { get; set; }

        /// <summary>
        /// 请求流水号，企信侧用于识别幂等请求
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 退费退权益的原因描述
        /// </summary>
        [XmlElement("reverse_reason")]
        public string ReverseReason { get; set; }
    }
}
