using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseFunctionTriggerSetResponse.
    /// </summary>
    public class AlipayCloudCloudbaseFunctionTriggerSetResponse : AopResponse
    {
        /// <summary>
        /// 设置触发器结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
