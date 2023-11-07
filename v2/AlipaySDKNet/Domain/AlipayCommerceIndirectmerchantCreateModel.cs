using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIndirectmerchantCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIndirectmerchantCreateModel : AopObject
    {
        /// <summary>
        /// 登录账号
        /// </summary>
        [XmlElement("login_id")]
        public string LoginId { get; set; }

        /// <summary>
        /// 商家logo图片地址
        /// </summary>
        [XmlElement("logo_url")]
        public string LogoUrl { get; set; }

        /// <summary>
        /// 应用id
        /// </summary>
        [XmlElement("merchant_app_id")]
        public string MerchantAppId { get; set; }

        /// <summary>
        /// 商家名称
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 分账关系信息
        /// </summary>
        [XmlArray("merchant_settle_relation_list")]
        [XmlArrayItem("merchant_settle_relation_processor_request")]
        public List<MerchantSettleRelationProcessorRequest> MerchantSettleRelationList { get; set; }

        /// <summary>
        /// 商家联系电话
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// smid
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }
    }
}
