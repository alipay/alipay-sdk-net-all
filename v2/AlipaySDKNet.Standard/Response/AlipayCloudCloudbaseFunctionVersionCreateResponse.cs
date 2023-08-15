using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseFunctionVersionCreateResponse.
    /// </summary>
    public class AlipayCloudCloudbaseFunctionVersionCreateResponse : AopResponse
    {
        /// <summary>
        /// 创建版本结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
