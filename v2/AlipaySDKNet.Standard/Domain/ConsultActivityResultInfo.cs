using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ConsultActivityResultInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ConsultActivityResultInfo : AopObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 咨询结果码  SUCCESS：可以领取  COUNT_OVER_LIMIT：不可领取，次数超过限制  BUDGET_NOT_ENOUGH：不可领取，预算不足  ACTIVITY_NOT_START：活动未开始  ACTIVITY_NOT_PERMISSION：商户没有权限发放该活动  OTHER：不可领取，未知原因
        /// </summary>
        [XmlElement("consult_result_code")]
        public string ConsultResultCode { get; set; }
    }
}
