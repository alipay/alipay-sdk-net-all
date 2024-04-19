using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceCliveConnectCreateResponse.
    /// </summary>
    public class AlipayIserviceCliveConnectCreateResponse : AopResponse
    {
        /// <summary>
        /// 响应
        /// </summary>
        [XmlElement("value")]
        public ConnectServerAdaptResult Value { get; set; }
    }
}
