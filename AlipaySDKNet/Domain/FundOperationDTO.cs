using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FundOperationDTO Data Structure.
    /// </summary>
    [Serializable]
    public class FundOperationDTO : AopObject
    {
        /// <summary>
        /// 支付宝系统中用以唯一标识用户签约记录的编号，调用签约接口成功时返回。
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 失败错误吗，仅明确失败且流水关单时返回
        /// </summary>
        [XmlElement("close_code")]
        public string CloseCode { get; set; }

        /// <summary>
        /// 失败原因，仅明确失败且流水关单时返回
        /// </summary>
        [XmlElement("close_reason")]
        public string CloseReason { get; set; }

        /// <summary>
        /// 支付时间
        /// </summary>
        [XmlElement("gmt_pay")]
        public string GmtPay { get; set; }

        /// <summary>
        /// 支付宝流水号
        /// </summary>
        [XmlElement("operation_id")]
        public string OperationId { get; set; }

        /// <summary>
        /// INIT：初始 PROCESSING：处理中 SUCCESS：成功 CLOSED：关闭
        /// </summary>
        [XmlElement("operation_status")]
        public string OperationStatus { get; set; }

        /// <summary>
        /// PURCHASE：申购 REVOKE：申购撤销 REDEEM：赎回
        /// </summary>
        [XmlElement("operation_type")]
        public string OperationType { get; set; }

        /// <summary>
        /// 展示在用户的消费记录中的订单标题
        /// </summary>
        [XmlElement("order_title")]
        public string OrderTitle { get; set; }

        /// <summary>
        /// 外部请求号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 申购撤销/赎回场景下必填 银行卡号（脱敏）/支付宝uid/NULL
        /// </summary>
        [XmlElement("principal_account")]
        public string PrincipalAccount { get; set; }

        /// <summary>
        /// 申购撤销/赎回场景下必填 ● BANKCARD：银行卡 ● ALIPAYACCOUNT：支付宝余额 ● SLIP：差错户
        /// </summary>
        [XmlElement("receive_asset")]
        public string ReceiveAsset { get; set; }
    }
}
