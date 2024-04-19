using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseFunctionVersionDeleteResponse.
    /// </summary>
    public class AlipayCloudCloudbaseFunctionVersionDeleteResponse : AopResponse
    {
        /// <summary>
        /// 版本删除结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
