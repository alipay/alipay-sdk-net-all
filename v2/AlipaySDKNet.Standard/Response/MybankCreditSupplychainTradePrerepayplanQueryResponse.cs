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
        /// 网商iprole_id
        /// </summary>
        [XmlElement("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 外部订单号, 同交易创建时一样 ${isv_iprole_id}_${zhifutong_ar_no}拼接而成 isv_iprole_id机构iproleId, zhifutong_ar_no 直付通签约订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 融租销售产品code
        /// </summary>
        [XmlElement("sale_pd_code")]
        public string SalePdCode { get; set; }

        /// <summary>
        /// 订单的状态， 正常，结清，逾期
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 订单全部分期的期数，默认M，代表月份
        /// </summary>
        [XmlElement("terms")]
        public long Terms { get; set; }

        /// <summary>
        /// 订单的全部金额： 本金+利息
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 订单明细，包含本金和利息
        /// </summary>
        [XmlElement("total_detail")]
        public BillTermAmountVO TotalDetail { get; set; }
    }
}
