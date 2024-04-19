using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpCreditloanCreditresultNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpCreditloanCreditresultNotifyModel : AopObject
    {
        /// <summary>
        /// 金融产品code码，接口提供方分配
        /// </summary>
        [XmlElement("financial_product_code")]
        public string FinancialProductCode { get; set; }

        /// <summary>
        /// 商户自身的请求id，需保证其唯一性
        /// </summary>
        [XmlElement("merchant_request_id")]
        public string MerchantRequestId { get; set; }

        /// <summary>
        /// 授信回调通知具体内容,JSON字符串
        /// </summary>
        [XmlElement("notify_content")]
        public string NotifyContent { get; set; }
    }
}
