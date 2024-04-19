using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcCreditWithdrawSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcCreditWithdrawSyncModel : AopObject
    {
        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("alipay_pay_no")]
        public string AlipayPayNo { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// bank_bill_no: 银行转账单号, 取款成功时填写 withdraw_serial_no: 资方内部取款单号, 取款成功时填写
        /// </summary>
        [XmlElement("ext_info")]
        public BankOrderInfo ExtInfo { get; set; }

        /// <summary>
        /// 审核失败原因，情况状态为APPROVE_FAIL时必填
        /// </summary>
        [XmlElement("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 取款方的真实业务订单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 请款状态，枚举 审核通过：APPROVE_PASS 审核失败：APPROVE_FAIL 取款成功: WITHDRAW_SUCCESS
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
