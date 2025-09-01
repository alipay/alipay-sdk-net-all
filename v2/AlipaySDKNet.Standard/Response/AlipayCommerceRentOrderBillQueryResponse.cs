using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRentOrderBillQueryResponse.
    /// </summary>
    public class AlipayCommerceRentOrderBillQueryResponse : AopResponse
    {
        /// <summary>
        /// 交易组件订单号
        /// </summary>
        [XmlElement("biz_order_id")]
        public string BizOrderId { get; set; }

        /// <summary>
        /// 订单关联用户支付明细列表
        /// </summary>
        [XmlArray("order_detail_list")]
        [XmlArrayItem("rent_bill_order_detail_dto")]
        public List<RentBillOrderDetailDto> OrderDetailList { get; set; }

        /// <summary>
        /// 订单关联分账明细列表
        /// </summary>
        [XmlArray("royalty_detail_list")]
        [XmlArrayItem("rent_bill_royalty_detail_dto")]
        public List<RentBillRoyaltyDetailDto> RoyaltyDetailList { get; set; }

        /// <summary>
        /// 实分总金额，单位元
        /// </summary>
        [XmlElement("total_actual_royalty_amount")]
        public string TotalActualRoyaltyAmount { get; set; }

        /// <summary>
        /// 应分总金额，单位元
        /// </summary>
        [XmlElement("total_royalty_amount")]
        public string TotalRoyaltyAmount { get; set; }
    }
}
