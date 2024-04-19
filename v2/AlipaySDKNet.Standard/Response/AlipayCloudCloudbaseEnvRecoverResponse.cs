using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseEnvRecoverResponse.
    /// </summary>
    public class AlipayCloudCloudbaseEnvRecoverResponse : AopResponse
    {
        /// <summary>
        /// 复机结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
