using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppYufalingsanyaowubYufalingsanyaowubQueryResponse.
    /// </summary>
    public class AlipayOpenAppYufalingsanyaowubYufalingsanyaowubQueryResponse : AopResponse
    {
        /// <summary>
        /// yufaa
        /// </summary>
        [XmlElement("yufaa")]
        public string Yufaa { get; set; }
    }
}
