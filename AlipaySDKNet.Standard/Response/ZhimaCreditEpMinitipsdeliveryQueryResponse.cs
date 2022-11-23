using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpMinitipsdeliveryQueryResponse.
    /// </summary>
    public class ZhimaCreditEpMinitipsdeliveryQueryResponse : AopResponse
    {
        /// <summary>
        /// 布尔值，有描述，有注意事项，必须
        /// </summary>
        [XmlElement("c")]
        public bool C { get; set; }

        /// <summary>
        /// 必须，三层复杂类型，有openid
        /// </summary>
        [XmlElement("jkjp")]
        public JinyoutestopenidThree Jkjp { get; set; }
    }
}
