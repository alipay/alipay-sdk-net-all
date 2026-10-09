using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingEntityQualificationVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingEntityQualificationVerifyModel : AopObject
    {
        /// <summary>
        /// 幂等号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// sn值
        /// </summary>
        [XmlElement("entity_id")]
        public string EntityId { get; set; }

        /// <summary>
        /// 用于透传商品额外信息
        /// </summary>
        [XmlElement("entity_info")]
        public string EntityInfo { get; set; }

        /// <summary>
        /// 商品
        /// </summary>
        [XmlElement("entity_type")]
        public string EntityType { get; set; }

        /// <summary>
        /// SN锁定
        /// </summary>
        [XmlElement("fund_scene")]
        public string FundScene { get; set; }
    }
}
