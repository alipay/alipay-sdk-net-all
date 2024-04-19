using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenOperationOpenbizmockRzoneQueryResponse.
    /// </summary>
    public class AlipayOpenOperationOpenbizmockRzoneQueryResponse : AopResponse
    {
        /// <summary>
        /// 测试
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

        /// <summary>
        /// RZ00B
        /// </summary>
        [XmlElement("zone_name")]
        public string ZoneName { get; set; }
    }
}
