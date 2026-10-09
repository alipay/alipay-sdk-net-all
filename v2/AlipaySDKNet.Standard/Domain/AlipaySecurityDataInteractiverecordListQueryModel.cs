using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityDataInteractiverecordListQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityDataInteractiverecordListQueryModel : AopObject
    {
        /// <summary>
        /// 起始值为1，若参数值<=0，则交互式风控侧取默认值1
        /// </summary>
        [XmlElement("current_page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// 过滤参数，JSON格式
        /// </summary>
        [XmlElement("filter_params")]
        public string FilterParams { get; set; }

        /// <summary>
        /// 若参数值<=0，则交互式风控侧取默认值10
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 租户id
        /// </summary>
        [XmlElement("tenant_id")]
        public string TenantId { get; set; }
    }
}
