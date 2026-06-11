using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportIndustryCardReceiveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportIndustryCardReceiveModel : AopObject
    {
        /// <summary>
        /// 卡模板code
        /// </summary>
        [XmlElement("card_template_code")]
        public string CardTemplateCode { get; set; }

        /// <summary>
        /// 行业场景编码
        /// </summary>
        [XmlElement("industry_scene")]
        public string IndustryScene { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 用户openId
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 开卡方式
        /// </summary>
        [XmlElement("open_type")]
        public string OpenType { get; set; }

        /// <summary>
        /// 业务幂等号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 合作方编码
        /// </summary>
        [XmlElement("partner_code")]
        public string PartnerCode { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
