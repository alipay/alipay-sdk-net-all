using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCcmCrmCallrecordQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCcmCrmCallrecordQueryModel : AopObject
    {
        /// <summary>
        /// 当前页码，可选参数，不选默认值为:1
        /// </summary>
        [XmlElement("current_page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// 线索ID
        /// </summary>
        [XmlElement("data_id")]
        public string DataId { get; set; }

        /// <summary>
        /// 页大小，可选，默认:10
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 租户实例id，必填，智能拓客平台分配
        /// </summary>
        [XmlElement("tenant_id")]
        public string TenantId { get; set; }
    }
}
