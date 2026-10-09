using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalFincloudFinsaasPutplanPauseModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalFincloudFinsaasPutplanPauseModel : AopObject
    {
        /// <summary>
        /// 操作人 id
        /// </summary>
        [XmlElement("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 投放计划 id
        /// </summary>
        [XmlElement("put_plan_id")]
        public long PutPlanId { get; set; }

        /// <summary>
        /// 租户 code
        /// </summary>
        [XmlElement("tenant_code")]
        public string TenantCode { get; set; }
    }
}
