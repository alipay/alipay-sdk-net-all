using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceTreeapifourteenRainystestQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceTreeapifourteenRainystestQueryResponse : AopResponse
    {
        /// <summary>
        /// test case for pre
        /// </summary>
        [XmlElement("demo_case")]
        public string DemoCase { get; set; }

        /// <summary>
        /// 完全copy引用复杂类型
        /// </summary>
        [XmlElement("res_copy_weak_ref")]
        public RainyComplexTypesTheFourteen ResCopyWeakRef { get; set; }

        /// <summary>
        /// 字段copy引用模型
        /// </summary>
        [XmlElement("res_field_weak_ref")]
        public RainyComplexTypesTheFourteen ResFieldWeakRef { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
