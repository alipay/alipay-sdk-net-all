using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossProdAntlescenterDocusignrecipientQueryResponse.
    /// </summary>
    public class AlipayBossProdAntlescenterDocusignrecipientQueryResponse : AopResponse
    {
        /// <summary>
        /// 签署url
        /// </summary>
        [XmlElement("view_url")]
        public string ViewUrl { get; set; }
    }
}
