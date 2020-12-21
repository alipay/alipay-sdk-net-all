using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InstalmentPlanDetailTuitionDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InstalmentPlanDetailTuitionDTO : AopObject
    {
        /// <summary>
        /// 完成的计划信息
        /// </summary>
        [XmlElement("plan")]
        public InstalmentPlanTuitionDTO Plan { get; set; }

        /// <summary>
        /// 打款计划涉及的周期配置
        /// </summary>
        [XmlElement("recharge_order")]
        public RechargeOrderTuitionDTO RechargeOrder { get; set; }
    }
}
