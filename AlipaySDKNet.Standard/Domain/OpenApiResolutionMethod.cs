using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiResolutionMethod Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiResolutionMethod : AopObject
    {
        /// <summary>
        /// Otp校验方法的标识
        /// </summary>
        [XmlElement("identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// Otp校验方法是否需要用户交互
        /// </summary>
        [XmlElement("requires_user_interaction")]
        public bool RequiresUserInteraction { get; set; }

        /// <summary>
        /// Otp校验方法类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// Otp校验方法的值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
