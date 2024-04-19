using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseQuotacontrolRuleDeleteResponse.
    /// </summary>
    public class AlipayCloudCloudbaseQuotacontrolRuleDeleteResponse : AopResponse
    {
        /// <summary>
        /// 删除结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
