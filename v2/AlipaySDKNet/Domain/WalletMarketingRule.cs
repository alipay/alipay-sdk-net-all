using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WalletMarketingRule Data Structure.
    /// </summary>
    [Serializable]
    public class WalletMarketingRule : AopObject
    {
        /// <summary>
        /// 营销类型
        /// </summary>
        [XmlElement("ma_type")]
        public string MaType { get; set; }

        /// <summary>
        /// 营销值，单位：%
        /// </summary>
        [XmlElement("ma_value")]
        public string MaValue { get; set; }

        /// <summary>
        /// 退营销金额，单位：元
        /// </summary>
        [XmlElement("refund_marketing_amount")]
        public string RefundMarketingAmount { get; set; }
    }
}
