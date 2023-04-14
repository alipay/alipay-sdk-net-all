using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditSupplychainCreditpayAmountQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditSupplychainCreditpayAmountQueryModel : AopObject
    {
        /// <summary>
        /// 品牌额度查询条件
        /// </summary>
        [XmlElement("brand_quota_query_condition")]
        public BrandQuotaQueryCondition BrandQuotaQueryCondition { get; set; }

        /// <summary>
        /// 买方信息，这里是ISV的信息
        /// </summary>
        [XmlElement("buyer")]
        public Member Buyer { get; set; }

        /// <summary>
        /// 平台类型
        /// </summary>
        [XmlElement("channel_tag")]
        public string ChannelTag { get; set; }

        /// <summary>
        /// Trace信息
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
