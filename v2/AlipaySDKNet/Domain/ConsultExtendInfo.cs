using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ConsultExtendInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ConsultExtendInfo : AopObject
    {
        /// <summary>
        /// 活动类型
        /// </summary>
        [XmlElement("campaign_type")]
        public string CampaignType { get; set; }

        /// <summary>
        /// 活动卡bin信息，可以配置多个，逗号区分
        /// </summary>
        [XmlElement("card_bin")]
        public string CardBin { get; set; }

        /// <summary>
        /// 卡类型,多个以","分隔
        /// </summary>
        [XmlElement("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// i站银行简称
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }
    }
}
