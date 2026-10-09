using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityDataIprShortplayCreateResponse.
    /// </summary>
    public class AlipaySecurityDataIprShortplayCreateResponse : AopResponse
    {
        /// <summary>
        /// 业务处理结果码对应文字说明
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }
    }
}
