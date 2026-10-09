using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenOperationOpenbizmockRzoneQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenOperationOpenbizmockRzoneQueryModel : AopObject
    {
        /// <summary>
        /// 测试专用
        /// </summary>
        [XmlElement("test_json")]
        public string TestJson { get; set; }

        /// <summary>
        /// 测试专用
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }

        /// <summary>
        /// 测试专用
        /// </summary>
        [XmlElement("uid_openid")]
        public string UidOpenid { get; set; }
    }
}
