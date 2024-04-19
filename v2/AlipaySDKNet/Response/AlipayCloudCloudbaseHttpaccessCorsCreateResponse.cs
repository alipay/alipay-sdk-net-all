using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseHttpaccessCorsCreateResponse.
    /// </summary>
    public class AlipayCloudCloudbaseHttpaccessCorsCreateResponse : AopResponse
    {
        /// <summary>
        /// 是否添加成功
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
