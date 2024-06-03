using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditBusinessPlanModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditBusinessPlanModifyModel : AopObject
    {
        /// <summary>
        /// 【免押】支付宝授权资金订单号。 与商户的授权资金订单号不能同时为空，二者都传入时，以支付宝资金授权订单号为准，该参数与支付宝授权资金操作流水号配对使用。
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 操作类型
        /// </summary>
        [XmlElement("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// 请求流水号，用于标示请求流水的唯一性。 仅支持字母、数字、下划线。
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 计划详情列表
        /// </summary>
        [XmlArray("plan_details")]
        [XmlArrayItem("credit_performance_plan_detail_open")]
        public List<CreditPerformancePlanDetailOpen> PlanDetails { get; set; }

        /// <summary>
        /// 产品标识，按枚举填入。
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
