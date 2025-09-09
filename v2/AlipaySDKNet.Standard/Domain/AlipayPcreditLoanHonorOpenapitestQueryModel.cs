using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditLoanHonorOpenapitestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditLoanHonorOpenapitestQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 优惠券发放结果
        /// </summary>
        [XmlElement("coupon_send_result")]
        public HonorCouponSendResultDTO CouponSendResult { get; set; }

        /// <summary>
        /// 授信申请单号
        /// </summary>
        [XmlElement("credit_apply_no")]
        public string CreditApplyNo { get; set; }

        /// <summary>
        /// 授信申请结果
        /// </summary>
        [XmlElement("credit_apply_result")]
        public HonorCreditApplyResultDTO CreditApplyResult { get; set; }

        /// <summary>
        /// 借款申请结果
        /// </summary>
        [XmlElement("lend_result")]
        public HonorLendApplyResultDTO LendResult { get; set; }

        /// <summary>
        /// 注销结果通知
        /// </summary>
        [XmlElement("logoff_result")]
        public HonorLogoffResultDTO LogoffResult { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 还款结果
        /// </summary>
        [XmlElement("repay_result")]
        public HonorRepayApplyResultDTO RepayResult { get; set; }

        /// <summary>
        /// unifygw结果
        /// </summary>
        [XmlElement("unifygw_result")]
        public HonorUnifygwCommonResult UnifygwResult { get; set; }
    }
}
