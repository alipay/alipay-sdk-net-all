using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IndustryIntactChargeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IndustryIntactChargeInfo : AopObject
    {
        /// <summary>
        /// 实际收费金额，单位元
        /// </summary>
        [XmlElement("actual_amount")]
        public string ActualAmount { get; set; }

        /// <summary>
        /// 收费类型
        /// </summary>
        [XmlElement("bill_type")]
        public string BillType { get; set; }

        /// <summary>
        /// 收费时间,时间精确到秒
        /// </summary>
        [XmlElement("gmt_pay")]
        public string GmtPay { get; set; }

        /// <summary>
        /// 是否退费
        /// </summary>
        [XmlElement("is_refund")]
        public string IsRefund { get; set; }

        /// <summary>
        /// 外部请求号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 应收费金额，单位元
        /// </summary>
        [XmlElement("plan_amount")]
        public string PlanAmount { get; set; }

        /// <summary>
        /// 收费产品
        /// </summary>
        [XmlElement("product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// 收费唯一id
        /// </summary>
        [XmlElement("service_target")]
        public string ServiceTarget { get; set; }

        /// <summary>
        /// 收费类型
        /// </summary>
        [XmlElement("service_type")]
        public string ServiceType { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 收费目标账号
        /// </summary>
        [XmlElement("target_account_no")]
        public string TargetAccountNo { get; set; }

        /// <summary>
        /// 收费目标uid
        /// </summary>
        [XmlElement("target_user_id")]
        public string TargetUserId { get; set; }
    }
}
