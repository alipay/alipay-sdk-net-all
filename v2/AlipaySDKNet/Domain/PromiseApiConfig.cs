using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PromiseApiConfig Data Structure.
    /// </summary>
    [Serializable]
    public class PromiseApiConfig : AopObject
    {
        /// <summary>
        /// 合约履约周期，以天为单位。
        /// </summary>
        [XmlElement("fulfillment_days")]
        public long FulfillmentDays { get; set; }

        /// <summary>
        /// 商户客服电话，为必填字段，需为合法电话号码。
        /// </summary>
        [XmlElement("merchant_service_phone")]
        public string MerchantServicePhone { get; set; }

        /// <summary>
        /// 商户主页链接，取值为商户小程序地址或H5页面地址。
        /// </summary>
        [XmlElement("merchant_service_url")]
        public string MerchantServiceUrl { get; set; }

        /// <summary>
        /// 守约操作（钱、物、行为）、promise_link（链接）、promise_remind（文本）
        /// </summary>
        [XmlElement("promise_operation_type")]
        public string PromiseOperationType { get; set; }

        /// <summary>
        /// 守约文案或守约链接
        /// </summary>
        [XmlElement("promise_operation_value")]
        public string PromiseOperationValue { get; set; }
    }
}
