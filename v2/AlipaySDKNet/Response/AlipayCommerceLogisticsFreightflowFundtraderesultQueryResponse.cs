using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLogisticsFreightflowFundtraderesultQueryResponse.
    /// </summary>
    public class AlipayCommerceLogisticsFreightflowFundtraderesultQueryResponse : AopResponse
    {
        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 支付方式
        /// </summary>
        [XmlElement("pay_asset_type")]
        public string PayAssetType { get; set; }

        /// <summary>
        /// 订单状态(无错误码返回时必填)
        /// </summary>
        [XmlElement("pay_status")]
        public string PayStatus { get; set; }

        /// <summary>
        /// 收方id
        /// </summary>
        [XmlElement("payee_id")]
        public string PayeeId { get; set; }

        /// <summary>
        /// 付方姓名
        /// </summary>
        [XmlElement("payer_name")]
        public string PayerName { get; set; }

        /// <summary>
        /// 订单总金额,单位:分
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }
    }
}
