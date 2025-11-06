using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHmUserskipQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalHmUserskipQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户跳转履约中间页url
        /// </summary>
        [XmlElement("skip_url")]
        public string SkipUrl { get; set; }
    }
}
