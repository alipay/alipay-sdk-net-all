using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditSupplychainTradePrerepayplanQueryResponse.
    /// </summary>
    public class MybankCreditSupplychainTradePrerepayplanQueryResponse : AopResponse
    {
        /// <summary>
        /// 账单分期列表
        /// </summary>
        [XmlArray("installment_repay_plans")]
        [XmlArrayItem("installment_repay_plan_v_o")]
        public List<InstallmentRepayPlanVO> InstallmentRepayPlans { get; set; }

        /// <summary>
        /// 网商ip信息
        /// </summary>
        [XmlElement("ip_id")]
        public string IpId { get; set; }

        /// <summary>
        /// 网商iprole
        /// </summary>
        [XmlElement("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// ${isv_iprole_id}_${zhifutong_ar_no}
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 融租销售产品code
        /// </summary>
        [XmlElement("sale_pd_code")]
        public string SalePdCode { get; set; }
    }
}
