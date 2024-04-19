using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenOperationOpenbizmockGzoneQueryResponse.
    /// </summary>
    public class AlipayOpenOperationOpenbizmockGzoneQueryResponse : AopResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

        /// <summary>
        /// ceshi
        /// </summary>
        [XmlElement("zone_name")]
        public string ZoneName { get; set; }
    }
}
