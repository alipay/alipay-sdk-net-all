using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoTestmanjiangGetResponse.
    /// </summary>
    public class AlipayEcoTestmanjiangGetResponse : AopResponse
    {
        /// <summary>
        /// 详细地址
        /// </summary>
        [XmlElement("addr")]
        public string Addr { get; set; }
    }
}
