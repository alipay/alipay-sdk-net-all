using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PayChannelInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PayChannelInfoDTO : AopObject
    {
        /// <summary>
        /// 资产id 例：银行卡绑定支付宝id
        /// </summary>
        [XmlElement("asset_id")]
        public string AssetId { get; set; }

        /// <summary>
        /// ●SINGLE_CHANNEL_MODE（限定渠道类型）  SPECIFIED_SORT_CHANNEL_MODE（优先渠道类型）
        /// </summary>
        [XmlElement("channel_mode")]
        public string ChannelMode { get; set; }

        /// <summary>
        /// 机构id ● CMB
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 支付渠道借贷类型 ● DC：借记卡 ● CC：贷记卡
        /// </summary>
        [XmlElement("pay_channel_debit_credit_type")]
        public string PayChannelDebitCreditType { get; set; }

        /// <summary>
        /// 支付工具类型 ● BANKCARD - 银行卡
        /// </summary>
        [XmlElement("pay_tool_type")]
        public string PayToolType { get; set; }
    }
}
