using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CardPromoDO Data Structure.
    /// </summary>
    [Serializable]
    public class CardPromoDO : AopObject
    {
        /// <summary>
        /// 卡片Id
        /// </summary>
        [XmlElement("card_id")]
        public string CardId { get; set; }

        /// <summary>
        /// 卡片星级
        /// </summary>
        [XmlElement("card_level")]
        public long CardLevel { get; set; }

        /// <summary>
        /// 是否限时权益
        /// </summary>
        [XmlElement("limit")]
        public bool Limit { get; set; }

        /// <summary>
        /// 权益图标
        /// </summary>
        [XmlElement("promo_icon")]
        public string PromoIcon { get; set; }

        /// <summary>
        /// 权益名称
        /// </summary>
        [XmlElement("promo_title")]
        public string PromoTitle { get; set; }

        /// <summary>
        /// 用户是否领取了该权益
        /// </summary>
        [XmlElement("received")]
        public bool Received { get; set; }

        /// <summary>
        /// 目标打卡次数，打卡target_mark_count天可以获取该权益
        /// </summary>
        [XmlElement("target_mark_count")]
        public long TargetMarkCount { get; set; }
    }
}
