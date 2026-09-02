using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcRecyclinginvoiceBiztransferSubmitResponse.
    /// </summary>
    public class AlipayCommerceEcRecyclinginvoiceBiztransferSubmitResponse : AopResponse
    {
        /// <summary>
        /// 支付流水号
        /// </summary>
        [XmlElement("alipay_pay_no")]
        public string AlipayPayNo { get; set; }

        /// <summary>
        /// 业务转账单据ID
        /// </summary>
        [XmlElement("biz_transfer_id")]
        public string BizTransferId { get; set; }

        /// <summary>
        /// 企业资金账户ID
        /// </summary>
        [XmlElement("company_account_id")]
        public string CompanyAccountId { get; set; }

        /// <summary>
        /// 转账失败的错误码，只有在转账失败时有值
        /// </summary>
        [XmlElement("fail_code")]
        public string FailCode { get; set; }

        /// <summary>
        /// 当转账失败的情况下，透出具体原因
        /// </summary>
        [XmlElement("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 支付成功的时间
        /// </summary>
        [XmlElement("gmt_pay")]
        public string GmtPay { get; set; }

        /// <summary>
        /// 外部业务转账单号
        /// </summary>
        [XmlElement("out_biz_transfer_id")]
        public string OutBizTransferId { get; set; }

        /// <summary>
        /// 收款账号
        /// </summary>
        [XmlElement("payee_account")]
        public string PayeeAccount { get; set; }

        /// <summary>
        /// 收款账号类型：PHONE / EMAIL
        /// </summary>
        [XmlElement("payee_account_type")]
        public string PayeeAccountType { get; set; }

        /// <summary>
        /// 收款人姓名
        /// </summary>
        [XmlElement("payee_name")]
        public string PayeeName { get; set; }

        /// <summary>
        /// 凭证文件ID
        /// </summary>
        [XmlElement("receipt_file_id")]
        public string ReceiptFileId { get; set; }

        /// <summary>
        /// 通过反向创建订单返回的订单id
        /// </summary>
        [XmlElement("recycling_order_id")]
        public string RecyclingOrderId { get; set; }

        /// <summary>
        /// 转账业务金额，单位元
        /// </summary>
        [XmlElement("transfer_biz_amount")]
        public string TransferBizAmount { get; set; }

        /// <summary>
        /// 转账状态：INIT / PROCESSING / SUCCESS / FAIL
        /// </summary>
        [XmlElement("transfer_biz_status")]
        public string TransferBizStatus { get; set; }

        /// <summary>
        /// 业务类型(LOGISTICS:物流，COMMISSION：分佣)
        /// </summary>
        [XmlElement("transfer_biz_type")]
        public string TransferBizType { get; set; }
    }
}
