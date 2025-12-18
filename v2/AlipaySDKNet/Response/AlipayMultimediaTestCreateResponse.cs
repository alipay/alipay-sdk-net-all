using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMultimediaTestCreateResponse.
    /// </summary>
    public class AlipayMultimediaTestCreateResponse : AopResponse
    {
        /// <summary>
        /// 基础参数
        /// </summary>
        [XmlElement("tc_case")]
        public string TcCase { get; set; }
    }
}
