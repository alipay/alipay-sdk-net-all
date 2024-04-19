using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasOpenPoboNotifyResponse.
    /// </summary>
    public class AlipayOverseasOpenPoboNotifyResponse : AopResponse
    {
        /// <summary>
        /// 结果返回
        /// </summary>
        [XmlElement("result")]
        public TuitionISVResult Result { get; set; }
    }
}
