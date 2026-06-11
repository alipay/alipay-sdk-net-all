using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AssetChannelInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AssetChannelInfo : AopObject
    {
        /// <summary>
        /// 资产类型编码
        /// </summary>
        [XmlElement("asset_type_code")]
        public string AssetTypeCode { get; set; }

        /// <summary>
        /// 卡类型：DC借记卡，CC贷记卡
        /// </summary>
        [XmlElement("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 银行卡所属的银行渠道,格式为:机构ID^渠道码,例如:ICBC^BIG_AMOUNT_CREDIT_CARTOON，花呗 INST_ALIPAY^PCREDIT_PAY)
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 渠道编码
        /// </summary>
        [XmlElement("channel_code")]
        public string ChannelCode { get; set; }

        /// <summary>
        /// 渠道标识
        /// </summary>
        [XmlElement("channel_type_code")]
        public string ChannelTypeCode { get; set; }

        /// <summary>
        /// 中国农业银行
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }
    }
}
