using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseEnvAkCreateResponse.
    /// </summary>
    public class AlipayCloudCloudbaseEnvAkCreateResponse : AopResponse
    {
        /// <summary>
        /// 创建ak结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
