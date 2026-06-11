using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BizCard Data Structure.
    /// </summary>
    [Serializable]
    public class BizCard : AopObject
    {
        /// <summary>
        /// 卡生效日期
        /// </summary>
        [XmlElement("active_time")]
        public string ActiveTime { get; set; }

        /// <summary>
        /// 卡详情跳转链接
        /// </summary>
        [XmlElement("card_link_url")]
        public string CardLinkUrl { get; set; }

        /// <summary>
        /// 卡名称
        /// </summary>
        [XmlElement("card_name")]
        public string CardName { get; set; }

        /// <summary>
        /// 卡号,只有开卡之后才返回该值
        /// </summary>
        [XmlElement("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 卡状态
        /// </summary>
        [XmlElement("card_status")]
        public string CardStatus { get; set; }

        /// <summary>
        /// 卡模板code
        /// </summary>
        [XmlElement("card_template_code")]
        public string CardTemplateCode { get; set; }

        /// <summary>
        /// 卡种类型,分为预付的储值卡和直接权益抵扣的权益卡
        /// </summary>
        [XmlElement("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 卡周期类型
        /// </summary>
        [XmlElement("card_validity_period_type")]
        public string CardValidityPeriodType { get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }
    }
}
