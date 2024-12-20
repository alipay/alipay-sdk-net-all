using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditLoanSideloanrepayRepayApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditLoanSideloanrepayRepayApplyModel : AopObject
    {
        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 申请还款金额，强制校验不为空且大于0
        /// </summary>
        [XmlElement("apply_repay_amount")]
        public string ApplyRepayAmount { get; set; }

        /// <summary>
        /// 扩展字段, 还款试算时会放入借据号列表和应还金额信息，还款提交时透传。
        /// </summary>
        [XmlElement("extension")]
        public string Extension { get; set; }

        /// <summary>
        /// 支用申请单号集合
        /// </summary>
        [XmlArray("loan_apply_no_list")]
        [XmlArrayItem("string")]
        public List<string> LoanApplyNoList { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 产品码, 信贷产品码销售外标 加 渠道编码组成，固定为: SL_PD_SALE_CODE-TAOTIAN
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 还款申请单号，业务幂等用
        /// </summary>
        [XmlElement("repay_apply_no")]
        public string RepayApplyNo { get; set; }

        /// <summary>
        /// 还款场景 PREPAY-提前还款 DUE_REPAY-到期逾期还款
        /// </summary>
        [XmlElement("repayment_scene")]
        public string RepaymentScene { get; set; }
    }
}
