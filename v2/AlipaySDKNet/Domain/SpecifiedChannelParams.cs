using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SpecifiedChannelParams Data Structure.
    /// </summary>
    [Serializable]
    public class SpecifiedChannelParams : AopObject
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
        /// 银行卡类型，只有在资产类型为BANKCA...
        /// </summary>
        [XmlElement("bank_card_type")]
        public string BankCardType { get; set; }

        /// <summary>
        /// 机构编码
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 资产类型，用以标识资产大类。
        /// </summary>
        [XmlElement("pay_tool_type")]
        public string PayToolType { get; set; }
    }
}
