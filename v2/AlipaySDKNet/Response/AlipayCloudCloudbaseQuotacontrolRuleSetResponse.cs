using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseQuotacontrolRuleSetResponse.
    /// </summary>
    public class AlipayCloudCloudbaseQuotacontrolRuleSetResponse : AopResponse
    {
        /// <summary>
        /// 设置结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
