using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundFlexiblestaffingRepaymentTransferModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundFlexiblestaffingRepaymentTransferModel : AopObject
    {
        /// <summary>
        /// 描述特定的业务场景。
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 零工卡专用金还款到卡扩展参数
        /// </summary>
        [XmlElement("business_params")]
        public RepaymentBusinessParams BusinessParams { get; set; }

        /// <summary>
        /// 借款协议号
        /// </summary>
        [XmlElement("loan_agreement_no")]
        public string LoanAgreementNo { get; set; }

        /// <summary>
        /// 转账订单标题
        /// </summary>
        [XmlElement("order_title")]
        public string OrderTitle { get; set; }

        /// <summary>
        /// 商家侧唯一订单号，由商家自定义。对于不同转账请求，商家需保证该订单号在自身系统唯一。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 转账还款收款方信息，部分场景可选。
        /// </summary>
        [XmlElement("payee_info")]
        public RepaymentParticipant PayeeInfo { get; set; }

        /// <summary>
        /// 业务产品码。
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 转账备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 转账金额（元）
        /// </summary>
        [XmlElement("trans_amount")]
        public string TransAmount { get; set; }
    }
}
