using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SpecifiedChannelParam Data Structure.
    /// </summary>
    [Serializable]
    public class SpecifiedChannelParam : AopObject
    {
        /// <summary>
        /// 指定渠道签约号
        /// </summary>
        [XmlElement("asset_id")]
        public string AssetId { get; set; }

        /// <summary>
        /// 资产编码
        /// </summary>
        [XmlElement("asset_type_code")]
        public string AssetTypeCode { get; set; }

        /// <summary>
        /// 银行卡类型，只有在资产类型为BANKCARD时才有效。如果为空，则标识不限制卡类型。卡类型在有值时，仅支持 两类传参：DD-贷记卡（储蓄卡），CC-信用卡。
        /// </summary>
        [XmlElement("bank_card_type")]
        public string BankCardType { get; set; }

        /// <summary>
        /// 机构编码
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 资产类型，用以标识资产大类。BANKCARD - 银行卡
        /// </summary>
        [XmlElement("pay_tool_type")]
        public string PayToolType { get; set; }
    }
}
