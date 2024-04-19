using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseFunctionPublishResponse.
    /// </summary>
    public class AlipayCloudCloudbaseFunctionPublishResponse : AopResponse
    {
        /// <summary>
        /// 发布结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
