using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalAicsDevinWorkGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalAicsDevinWorkGetModel : AopObject
    {
        /// <summary>
        /// 数字人标识code
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 变量分页当前页码，默认1
        /// </summary>
        [XmlElement("current_page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// 变量分页每页条数，默认100
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        [XmlElement("tenant_id")]
        public string TenantId { get; set; }
    }
}
