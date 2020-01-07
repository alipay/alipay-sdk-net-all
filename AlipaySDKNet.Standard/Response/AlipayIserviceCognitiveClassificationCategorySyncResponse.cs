using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceCognitiveClassificationCategorySyncResponse.
    /// </summary>
    public class AlipayIserviceCognitiveClassificationCategorySyncResponse : AopResponse
    {
        /// <summary>
        /// 错误code
        /// </summary>
        [XmlElement("err_code")]
        public string ErrCode { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [XmlElement("err_msg")]
        public string ErrMsg { get; set; }

        /// <summary>
        /// 是否正确
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
