using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PromiseConfigDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PromiseConfigDTO : AopObject
    {
        /// <summary>
        /// 商户客服电话，为必填字段，需为合法电话号码。
        /// </summary>
        [XmlElement("merchant_service_phone")]
        public string MerchantServicePhone { get; set; }

        /// <summary>
        /// 必填，promise_link（链接）、promise_remind（文本）
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
