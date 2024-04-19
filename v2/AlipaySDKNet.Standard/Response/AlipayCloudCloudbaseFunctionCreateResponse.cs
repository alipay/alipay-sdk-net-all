using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseFunctionCreateResponse.
    /// </summary>
    public class AlipayCloudCloudbaseFunctionCreateResponse : AopResponse
    {
        /// <summary>
        /// 函数创建结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
