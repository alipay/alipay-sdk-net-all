using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundTransUniTransferResponse.
    /// </summary>
    public class AlipayFundTransUniTransferResponse : AopResponse
    {
        /// <summary>
        /// 转账金额，单位为元，默认为空，特殊场景提供。
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 支付宝转账订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 支付宝支付资金流水号
        /// </summary>
        [XmlElement("pay_fund_order_id")]
        public string PayFundOrderId { get; set; }

        /// <summary>
        /// 金融机构发起签约类、支付类、差错类业务时，应为每笔业务分配唯一的交易流水号。31位交易流水号组成规则为：“8位日期”+“16位序列号”+“1位预留位”+“6位控制位”，其中： a）“8位日期”为系统当前日期，ISODate格式：“YYYYMMDD” b）“16位序列号”由金融机构生成，金融机构应确保该值在网联当日唯一 c）“1位预留位”由平台分配 d）“6位控制位”由金融机构通过平台获取 例如：2023052993044491260542090100400
        /// </summary>
        [XmlElement("settle_serial_no")]
        public string SettleSerialNo { get; set; }

        /// <summary>
        /// 转账单据状态。 SUCCESS（该笔转账交易成功）：成功； FAIL：失败（具体失败原因请参见error_code以及fail_reason返回值）； DEALING：处理中（转账到支付宝账户不涉及）； REFUND：退票（转账到支付宝账户不涉及）；
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 订单支付时间，格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("trans_date")]
        public string TransDate { get; set; }
    }
}
