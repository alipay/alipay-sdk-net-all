using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalFincloudFinsaasInsuranceHistoryruleQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalFincloudFinsaasInsuranceHistoryruleQueryModel : AopObject
    {
        /// <summary>
        /// 实例id
        /// </summary>
        [XmlElement("instance_id")]
        public string InstanceId { get; set; }

        /// <summary>
        /// 外部租户id
        /// </summary>
        [XmlElement("out_tenant_id")]
        public string OutTenantId { get; set; }

        /// <summary>
        /// 分页页码
        /// </summary>
        [XmlElement("page_number")]
        public string PageNumber { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }
    }
}
