using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFincoreComplianceCustomsInfoCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFincoreComplianceCustomsInfoCreateModel : AopObject
    {
        /// <summary>
        /// 地区编号
        /// </summary>
        [XmlElement("area_code")]
        public string AreaCode { get; set; }

        /// <summary>
        /// buyer_name+不唯一+海关推送边民信息+无+海关传入+供海关调用
        /// </summary>
        [XmlElement("buyer_name")]
        public string BuyerName { get; set; }

        /// <summary>
        /// cert_no+不唯一+海关推送边民信息+无+海关传入+证件号码
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// cert_type+不唯一+海关推送边民信息+IDENTITY_CARD+海关传入+供海关调用
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// merchant_id + 否 + 边民信息录入 + 无 + 海关传入 + 海关边民信息录入
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// merchant_order_no+唯一+海关推送边民信息+无+海关传入+供海关调用
        /// </summary>
        [XmlElement("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// store_id + 否 + 边民信息录入 + 无 + 海关传入 + 海关边民信息录入
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
