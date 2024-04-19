using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniOrderAftersaleCreateResponse.
    /// </summary>
    public class AlipayOpenMiniOrderAftersaleCreateResponse : AopResponse
    {
        /// <summary>
        /// 平台售后id
        /// </summary>
        [XmlElement("aftersale_id")]
        public string AftersaleId { get; set; }

        /// <summary>
        /// 外部售后单号
        /// </summary>
        [XmlElement("out_aftersale_id")]
        public string OutAftersaleId { get; set; }
    }
}
