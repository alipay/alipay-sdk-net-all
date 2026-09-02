using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcRecyclinginvoiceBiztransferSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcRecyclinginvoiceBiztransferSubmitModel : AopObject
    {
        /// <summary>
        /// 企业转账账户ID
        /// </summary>
        [XmlElement("company_account_id")]
        public string CompanyAccountId { get; set; }

        /// <summary>
        /// 外部业务转账单号（幂等键）
        /// </summary>
        [XmlElement("out_biz_transfer_id")]
        public string OutBizTransferId { get; set; }

        /// <summary>
        /// 支付宝收款账号，邮箱账号|手机号账号
        /// </summary>
        [XmlElement("payee_account")]
        public string PayeeAccount { get; set; }

        /// <summary>
        /// 传入的支付宝账号类型，手机号或者邮箱账号
        /// </summary>
        [XmlElement("payee_account_type")]
        public string PayeeAccountType { get; set; }

        /// <summary>
        /// 收款方姓名，校验收款账号是否正确
        /// </summary>
        [XmlElement("payee_name")]
        public string PayeeName { get; set; }

        /// <summary>
        /// 订单号，调用反向订单创建接口时返回
        /// </summary>
        [XmlElement("recycling_order_id")]
        public string RecyclingOrderId { get; set; }

        /// <summary>
        /// 企业的税号
        /// </summary>
        [XmlElement("tax_no")]
        public string TaxNo { get; set; }

        /// <summary>
        /// 转账业务金额 单位：元
        /// </summary>
        [XmlElement("transfer_biz_amount")]
        public string TransferBizAmount { get; set; }

        /// <summary>
        /// 区分转账的业务类型
        /// </summary>
        [XmlElement("transfer_biz_type")]
        public string TransferBizType { get; set; }
    }
}
