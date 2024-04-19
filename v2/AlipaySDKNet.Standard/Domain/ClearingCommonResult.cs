using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ClearingCommonResult Data Structure.
    /// </summary>
    [Serializable]
    public class ClearingCommonResult : AopObject
    {
        /// <summary>
        /// 返回结果code
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 结果中文描述 EXECUTE_SUCCESS UNKNOWN_EXCEPTION DATABASE_EXCEPTION
        /// </summary>
        [XmlElement("result_description")]
        public string ResultDescription { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
