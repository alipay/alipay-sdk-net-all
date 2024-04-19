using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseEnvStopResponse.
    /// </summary>
    public class AlipayCloudCloudbaseEnvStopResponse : AopResponse
    {
        /// <summary>
        /// 停服结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
