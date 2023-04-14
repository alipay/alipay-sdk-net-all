using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneEcommercePurchaselinkAuthModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneEcommercePurchaselinkAuthModel : AopObject
    {
        /// <summary>
        /// 至少订购天数
        /// </summary>
        [XmlElement("at_least_days")]
        public long AtLeastDays { get; set; }

        /// <summary>
        /// 订购主体为商品维度时必传
        /// </summary>
        [XmlElement("ecom_item")]
        public EcomItemDTO EcomItem { get; set; }

        /// <summary>
        /// 客户端用户ID
        /// </summary>
        [XmlElement("login_user_id")]
        public string LoginUserId { get; set; }

        /// <summary>
        /// session过期时间
        /// </summary>
        [XmlElement("out_session_expiration")]
        public string OutSessionExpiration { get; set; }

        /// <summary>
        /// session_id
        /// </summary>
        [XmlElement("out_session_id")]
        public string OutSessionId { get; set; }

        /// <summary>
        /// 合作商标识
        /// </summary>
        [XmlElement("partner_org_id")]
        public string PartnerOrgId { get; set; }

        /// <summary>
        /// 指定订购产品码:YFX(运费险),SHX(售后险)
        /// </summary>
        [XmlArray("product_code")]
        [XmlArrayItem("string")]
        public List<string> ProductCode { get; set; }

        /// <summary>
        /// 订购主体维度:PURCHASE_USER 订购人（卖家维度）,ECOM_ITEM  商品维度
        /// </summary>
        [XmlElement("related_subject_type")]
        public string RelatedSubjectType { get; set; }

        /// <summary>
        /// 卖家信息
        /// </summary>
        [XmlElement("seller")]
        public EcomSellerDTO Seller { get; set; }

        /// <summary>
        /// 客户端渠道：ios / android / pc / wx_applet(微信小程序)
        /// </summary>
        [XmlElement("user_client")]
        public string UserClient { get; set; }
    }
}
