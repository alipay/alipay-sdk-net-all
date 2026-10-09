using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ErrorDeliveryConfig Data Structure.
    /// </summary>
    [Serializable]
    public class ErrorDeliveryConfig : AopObject
    {
        /// <summary>
        /// 投放配置
        /// </summary>
        [XmlElement("delivery_config")]
        public DeliveryConfig DeliveryConfig { get; set; }

        /// <summary>
        /// 错误码。针对单个投放，具体的错误原因。
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 详细的投放错误信息。用于判断具体的错误信息。
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }
    }
}
