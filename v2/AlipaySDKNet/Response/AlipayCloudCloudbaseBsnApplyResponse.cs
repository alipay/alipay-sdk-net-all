using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseBsnApplyResponse.
    /// </summary>
    public class AlipayCloudCloudbaseBsnApplyResponse : AopResponse
    {
        /// <summary>
        /// 备案服务码
        /// </summary>
        [XmlElement("bsn")]
        public string Bsn { get; set; }
    }
}
