using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalOrderRefundQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalOrderRefundQueryResponse : AopResponse
    {
        /// <summary>
        /// 退款订单列表
        /// </summary>
        [XmlArray("refund_list")]
        [XmlArrayItem("refund_order_detail_v_o")]
        public List<RefundOrderDetailVO> RefundList { get; set; }
    }
}
