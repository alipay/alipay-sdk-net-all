using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditLoantradePayAssetConsultResponse.
    /// </summary>
    public class MybankCreditLoantradePayAssetConsultResponse : AopResponse
    {
        /// <summary>
        /// 账期资产视图，如果未咨询账期资产，可能为空
        /// </summary>
        [XmlArray("bill_assets")]
        [XmlArrayItem("credit_pay_bill_asset_v_o")]
        public List<CreditPayBillAssetVO> BillAssets { get; set; }

        /// <summary>
        /// 分期资产视图，如果未咨询分期资产，可能为空
        /// </summary>
        [XmlArray("installment_assets")]
        [XmlArrayItem("credit_pay_installment_asset_v_o")]
        public List<CreditPayInstallmentAssetVO> InstallmentAssets { get; set; }

        /// <summary>
        /// 咨询失败拒绝信息，只有在success为false的时候才存在
        /// </summary>
        [XmlElement("refuse_info")]
        public CreditPayRefuseVO RefuseInfo { get; set; }

        /// <summary>
        /// 咨询是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
