using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossSWsstestAddResponse.
    /// </summary>
    public class AlipayBossSWsstestAddResponse : AopResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("ss")]
        public string Ss { get; set; }
    }
}
