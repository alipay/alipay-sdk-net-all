using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalFincloudFinsaasPutplanRecoverModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalFincloudFinsaasPutplanRecoverModel : AopObject
    {
        /// <summary>
        /// 操作人 id
        /// </summary>
        [XmlElement("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 投放计划主键 id
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
