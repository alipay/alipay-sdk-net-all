using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryRentHousingQueryResponse.
    /// </summary>
    public class AlipayEbppIndustryRentHousingQueryResponse : AopResponse
    {
        /// <summary>
        /// 账单中公积金支付的总金额，单位(元)精确到分
        /// </summary>
        [XmlElement("acc_amount")]
        public string AccAmount { get; set; }

        /// <summary>
        /// 租房平台请求支付时的预创单编号
        /// </summary>
        [XmlElement("biz_seq")]
        public string BizSeq { get; set; }

        /// <summary>
        /// 订单状态说明
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 公积金中心的租房提取编号
        /// </summary>
        [XmlElement("org_biz_no")]
        public string OrgBizNo { get; set; }

        /// <summary>
        /// 账单中自付费金额，单位(元)精确到分
        /// </summary>
        [XmlElement("self_amount")]
        public string SelfAmount { get; set; }

        /// <summary>
        /// 租房平台房源租赁账单标题
        /// </summary>
        [XmlElement("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// 租房账单的总金额，单位(元)精确到分
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 支付宝交易单号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
