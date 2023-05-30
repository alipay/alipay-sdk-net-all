using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalFincloudFinsaasInsuranceInstanceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalFincloudFinsaasInsuranceInstanceQueryModel : AopObject
    {
        /// <summary>
        /// 外部系统用户ID
        /// </summary>
        [XmlElement("out_tenant_id")]
        public string OutTenantId { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_number")]
        public string PageNumber { get; set; }

        /// <summary>
        /// 页面大小
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }
    }
}
