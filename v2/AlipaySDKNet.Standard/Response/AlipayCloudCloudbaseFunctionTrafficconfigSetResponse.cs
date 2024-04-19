using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseFunctionTrafficconfigSetResponse.
    /// </summary>
    public class AlipayCloudCloudbaseFunctionTrafficconfigSetResponse : AopResponse
    {
        /// <summary>
        /// 设置流量分配配置结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
