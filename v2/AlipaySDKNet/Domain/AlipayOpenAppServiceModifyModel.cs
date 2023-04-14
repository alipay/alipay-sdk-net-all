using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppServiceModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppServiceModifyModel : AopObject
    {
        /// <summary>
        /// 服务schema版本
        /// </summary>
        [XmlElement("schema_version")]
        public string SchemaVersion { get; set; }

        /// <summary>
        /// 服务id
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 服务内容xml格式
        /// </summary>
        [XmlElement("service_xml")]
        public string ServiceXml { get; set; }
    }
}
