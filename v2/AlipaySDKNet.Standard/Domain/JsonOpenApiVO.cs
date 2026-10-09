using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// JsonOpenApiVO Data Structure.
    /// </summary>
    [Serializable]
    public class JsonOpenApiVO : AopObject
    {
        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("err_msg")]
        public string ErrMsg { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public string Success { get; set; }
    }
}
