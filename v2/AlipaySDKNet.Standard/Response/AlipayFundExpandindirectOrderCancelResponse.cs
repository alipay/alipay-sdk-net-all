using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundExpandindirectOrderCancelResponse.
    /// </summary>
    public class AlipayFundExpandindirectOrderCancelResponse : AopResponse
    {
        /// <summary>
        /// 进件单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 外部单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 进件单状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
