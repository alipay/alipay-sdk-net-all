using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenPublicComptestCreateResponse.
    /// </summary>
    public class AlipayOpenPublicComptestCreateResponse : AopResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

        /// <summary>
        /// 2
        /// </summary>
        [XmlElement("resulttwo")]
        public string Resulttwo { get; set; }
    }
}
