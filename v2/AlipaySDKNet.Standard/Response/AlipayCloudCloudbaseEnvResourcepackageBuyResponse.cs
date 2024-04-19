using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseEnvResourcepackageBuyResponse.
    /// </summary>
    public class AlipayCloudCloudbaseEnvResourcepackageBuyResponse : AopResponse
    {
        /// <summary>
        /// 购买结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
