using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcConsumeDetailQueryResponse.
    /// </summary>
    public class AlipayCommerceEcConsumeDetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 账单信息
        /// </summary>
        [XmlElement("consume_info")]
        public EcConsumeInfo ConsumeInfo { get; set; }

        /// <summary>
        /// 关联订单详情
        /// </summary>
        [XmlElement("related_order_info")]
        public EcOrderInfo RelatedOrderInfo { get; set; }

        /// <summary>
        /// 关联账单列表
        /// </summary>
        [XmlArray("related_refund_list")]
        [XmlArrayItem("ec_consume_info")]
        public List<EcConsumeInfo> RelatedRefundList { get; set; }

        /// <summary>
        /// 关联凭证详情列表
        /// </summary>
        [XmlArray("related_voucher_list")]
        [XmlArrayItem("ec_voucher_info")]
        public List<EcVoucherInfo> RelatedVoucherList { get; set; }
    }
}
