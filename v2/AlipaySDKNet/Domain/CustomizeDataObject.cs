using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CustomizeDataObject Data Structure.
    /// </summary>
    [Serializable]
    public class CustomizeDataObject : AopObject
    {
        /// <summary>
        /// 商业中台产品实例ID
        /// </summary>
        [XmlElement("instance_id")]
        public string InstanceId { get; set; }

        /// <summary>
        /// 商业中台产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 商业中台租户企业名称
        /// </summary>
        [XmlElement("tenant_company_name")]
        public string TenantCompanyName { get; set; }

        /// <summary>
        /// 商业中台租户ID
        /// </summary>
        [XmlElement("tenant_id")]
        public string TenantId { get; set; }
    }
}
