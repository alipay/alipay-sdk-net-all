using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpInteopAppauthCreateResponse.
    /// </summary>
    public class AlipayOpenSpInteopAppauthCreateResponse : AopResponse
    {
        /// <summary>
        /// 子单号
        /// </summary>
        [XmlElement("sub_order_no")]
        public string SubOrderNo { get; set; }
    }
}
