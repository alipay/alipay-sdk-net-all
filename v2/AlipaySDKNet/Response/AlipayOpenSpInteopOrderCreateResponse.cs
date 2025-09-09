using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpInteopOrderCreateResponse.
    /// </summary>
    public class AlipayOpenSpInteopOrderCreateResponse : AopResponse
    {
        /// <summary>
        /// 一体化作业开通主单号
        /// </summary>
        [XmlElement("inteop_order_no")]
        public string InteopOrderNo { get; set; }
    }
}
