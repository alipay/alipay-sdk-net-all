using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInstserviceOrderCreateResponse.
    /// </summary>
    public class AlipayEbppInstserviceOrderCreateResponse : AopResponse
    {
        /// <summary>
        /// 机构传入的流水号
        /// </summary>
        [XmlElement("flow_id")]
        public string FlowId { get; set; }

        /// <summary>
        /// 落地结果
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
