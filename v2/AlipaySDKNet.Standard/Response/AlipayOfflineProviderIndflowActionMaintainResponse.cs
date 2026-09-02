using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineProviderIndflowActionMaintainResponse.
    /// </summary>
    public class AlipayOfflineProviderIndflowActionMaintainResponse : AopResponse
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("reported")]
        public bool Reported { get; set; }
    }
}
