using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCertificateUserBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCertificateUserBatchqueryModel : AopObject
    {
        /// <summary>
        /// 凭证归属的商户id。该参数为空时取当前请求商户id
        /// </summary>
        [XmlElement("belong_merchant_id")]
        public string BelongMerchantId { get; set; }

        /// <summary>
        /// 凭证状态筛选
        /// </summary>
        [XmlElement("certificate_status")]
        public string CertificateStatus { get; set; }

        /// <summary>
        /// 支付宝用户openId
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 分页查询页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页查询单页数据条数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 支付宝的门店id，用于判断凭证是否可在此门店进行核销。
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 出资的支付宝用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
