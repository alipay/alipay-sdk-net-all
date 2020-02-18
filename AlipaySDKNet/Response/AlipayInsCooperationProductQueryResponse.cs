using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsCooperationProductQueryResponse.
    /// </summary>
    public class AlipayInsCooperationProductQueryResponse : AopResponse
    {
        /// <summary>
        /// 保险产品
        /// </summary>
        [XmlElement("product")]
        public InsProduct Product { get; set; }
    }
}
