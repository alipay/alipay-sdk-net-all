using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcTransOrderQueryResponse.
    /// </summary>
    public class AlipayCommerceEcTransOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// 转账总金额，单位为元，精确到小数点后两位
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 转账通道费，转账到卡是会产生。单位为元，精确到小数点后两位
        /// </summary>
        [XmlElement("order_fee")]
        public string OrderFee { get; set; }

        /// <summary>
        /// 支付宝转账单
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 商家订单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 宝支付资金流水号
        /// </summary>
        [XmlElement("pay_fund_order_id")]
        public string PayFundOrderId { get; set; }

        /// <summary>
        /// SUCCESS：成功（对转账到银行卡的单据, 该状态可能变为退票[REFUND]）； FAIL：失败； DEALING：处理中（转账到支付宝账户不涉及）； REFUND：退票（转账到支付宝账户不涉及）
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
