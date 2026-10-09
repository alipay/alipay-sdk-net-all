using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseFunctionModifyResponse.
    /// </summary>
    public class AlipayCloudCloudbaseFunctionModifyResponse : AopResponse
    {
        /// <summary>
        /// 修改函数结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
