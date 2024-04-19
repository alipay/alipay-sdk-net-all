using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenOperationOpenbizmockGzoneQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenOperationOpenbizmockGzoneQueryModel : AopObject
    {
        /// <summary>
        /// 测试
        /// </summary>
        [XmlElement("a")]
        public string A { get; set; }

        /// <summary>
        /// 测试
        /// </summary>
        [XmlElement("a_openid")]
        public string AOpenid { get; set; }
    }
}
