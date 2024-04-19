using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainDefinSaasPaymentQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainDefinSaasPaymentQueryModel : AopObject
    {
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
        /// 会员所属业务平台在智能科技的会员ID
        /// </summary>
        [XmlElement("platform_member_id")]
        public string PlatformMemberId { get; set; }
    }
}
