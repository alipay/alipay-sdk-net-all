using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotMdeviceprodAccountQueryResponse.
    /// </summary>
    public class AlipayCommerceIotMdeviceprodAccountQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 用户pid
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }
    }
}
