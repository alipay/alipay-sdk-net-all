using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalFincloudFinsaasInsuranceOutproductlistQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalFincloudFinsaasInsuranceOutproductlistQueryModel : AopObject
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
    }
}
