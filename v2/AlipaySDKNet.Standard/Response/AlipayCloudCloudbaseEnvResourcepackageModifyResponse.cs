using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseEnvResourcepackageModifyResponse.
    /// </summary>
    public class AlipayCloudCloudbaseEnvResourcepackageModifyResponse : AopResponse
    {
        /// <summary>
        /// 升降配结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
