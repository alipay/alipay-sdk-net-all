using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenDesCreateResponse.
    /// </summary>
    public class AlipayOpenDesCreateResponse : AopResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("ces")]
        public GavintestNewLeveaOne Ces { get; set; }
    }
}
