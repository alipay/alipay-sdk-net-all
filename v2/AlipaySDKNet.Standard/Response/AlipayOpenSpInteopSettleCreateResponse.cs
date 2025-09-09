using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpInteopSettleCreateResponse.
    /// </summary>
    public class AlipayOpenSpInteopSettleCreateResponse : AopResponse
    {
        /// <summary>
        /// 一体化作业子项申请单号
        /// </summary>
        [XmlElement("sub_order_no")]
        public string SubOrderNo { get; set; }
    }
}
