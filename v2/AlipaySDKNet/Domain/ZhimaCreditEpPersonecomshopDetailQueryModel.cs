using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpPersonecomshopDetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpPersonecomshopDetailQueryModel : AopObject
    {
        /// <summary>
        /// 授权编号
        /// </summary>
        [XmlElement("auth_id")]
        public string AuthId { get; set; }

        /// <summary>
        /// 业务关键词
        /// </summary>
        [XmlElement("business_key")]
        public string BusinessKey { get; set; }

        /// <summary>
        /// 企业标识（统一信用代码/注册号/企业名）
        /// </summary>
        [XmlElement("company_key")]
        public string CompanyKey { get; set; }

        /// <summary>
        /// 请求唯一编号，每次请求保持唯一
        /// </summary>
        [XmlElement("merchant_request_id")]
        public string MerchantRequestId { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
