using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseAntifloodRuleCreateResponse.
    /// </summary>
    public class AlipayCloudCloudbaseAntifloodRuleCreateResponse : AopResponse
    {
        /// <summary>
        /// 创建结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
