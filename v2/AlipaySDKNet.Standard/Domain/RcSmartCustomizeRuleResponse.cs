using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RcSmartCustomizeRuleResponse Data Structure.
    /// </summary>
    [Serializable]
    public class RcSmartCustomizeRuleResponse : AopObject
    {
        /// <summary>
        /// 创建返回结果
        /// </summary>
        [XmlElement("data")]
        public CustomizeRuleResult Data { get; set; }

        /// <summary>
        /// 返回的提示信息
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }

        /// <summary>
        /// 返回的结果编码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 受理请求是否成功 true成功，false失败
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
