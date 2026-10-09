using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseEnvStatusSetResponse.
    /// </summary>
    public class AlipayCloudCloudbaseEnvStatusSetResponse : AopResponse
    {
        /// <summary>
        /// 设置结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
