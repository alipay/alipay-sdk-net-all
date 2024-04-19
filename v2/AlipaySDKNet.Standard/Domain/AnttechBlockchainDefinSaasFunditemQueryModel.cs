using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainDefinSaasFunditemQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainDefinSaasFunditemQueryModel : AopObject
    {
        /// <summary>
        /// 资金操作类型。CAPTURE(请款);CANCEL(撤销/退款);
        /// </summary>
        [XmlElement("fund_type")]
        public string FundType { get; set; }

        /// <summary>
        /// 外部业务平台原始交易号
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 付款方外部业务平台会员ID
        /// </summary>
        [XmlElement("out_payer_id")]
        public ReferenceId OutPayerId { get; set; }

        /// <summary>
        /// 外部请求ID，需要支持部分请款/退款的平台必填
        /// </summary>
        [XmlElement("out_request_id")]
        public string OutRequestId { get; set; }

        /// <summary>
        /// 会员所属业务平台在智能科技的会员ID
        /// </summary>
        [XmlElement("platform_member_id")]
        public string PlatformMemberId { get; set; }
    }
}
