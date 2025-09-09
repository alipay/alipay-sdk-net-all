using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiMerchantPsiteSignupModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiMerchantPsiteSignupModel : AopObject
    {
        /// <summary>
        /// 期数维度贴息比例
        /// </summary>
        [XmlArray("fq_num_charge_info")]
        [XmlArrayItem("fq_num_charge_info")]
        public List<FqNumChargeInfo> FqNumChargeInfo { get; set; }

        /// <summary>
        /// 订单金额上限（分）要求为100整数倍
        /// </summary>
        [XmlElement("max_apply_amt")]
        public long MaxApplyAmt { get; set; }

        /// <summary>
        /// 报名商家列表
        /// </summary>
        [XmlArray("merchant_ids")]
        [XmlArrayItem("string")]
        public List<string> MerchantIds { get; set; }

        /// <summary>
        /// 订单金额下限（分）要求为100整数倍
        /// </summary>
        [XmlElement("min_apply_amt")]
        public long MinApplyAmt { get; set; }

        /// <summary>
        /// 外部请求号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 方案id
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }
    }
}
