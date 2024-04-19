using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityDataSssModifyResponse.
    /// </summary>
    public class AlipaySecurityDataSssModifyResponse : AopResponse
    {
        /// <summary>
        /// 复杂类型
        /// </summary>
        [XmlElement("dff")]
        public ActivityGoods Dff { get; set; }

        /// <summary>
        /// 323
        /// </summary>
        [XmlElement("kjkj")]
        public string Kjkj { get; set; }
    }
}
