using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiDeliverQueryResponse.
    /// </summary>
    public class AlipayPcreditHuabeiDeliverQueryResponse : AopResponse
    {
        /// <summary>
        /// 配置ID
        /// </summary>
        [XmlElement("config_id")]
        public string ConfigId { get; set; }
    }
}
