using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniAmpeCollectrightQueryResponse.
    /// </summary>
    public class AlipayOpenMiniAmpeCollectrightQueryResponse : AopResponse
    {
        /// <summary>
        /// true为有上报权限
        /// </summary>
        [XmlElement("can_collect")]
        public bool CanCollect { get; set; }
    }
}
