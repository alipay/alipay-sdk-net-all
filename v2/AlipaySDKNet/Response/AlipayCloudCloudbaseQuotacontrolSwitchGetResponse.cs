using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseQuotacontrolSwitchGetResponse.
    /// </summary>
    public class AlipayCloudCloudbaseQuotacontrolSwitchGetResponse : AopResponse
    {
        /// <summary>
        /// 额度防控开关状态
        /// </summary>
        [XmlElement("enable")]
        public bool Enable { get; set; }
    }
}
