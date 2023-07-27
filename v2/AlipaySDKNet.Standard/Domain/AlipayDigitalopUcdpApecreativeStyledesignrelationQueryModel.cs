using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDigitalopUcdpApecreativeStyledesignrelationQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDigitalopUcdpApecreativeStyledesignrelationQueryModel : AopObject
    {
        /// <summary>
        /// designId 唯一用来查询所有的布局风格关以及关联表的信息。
        /// </summary>
        [XmlElement("design_id")]
        public string DesignId { get; set; }

        /// <summary>
        /// page唯一用于分页。如果传空，默认为第一页
        /// </summary>
        [XmlElement("page_number")]
        public string PageNumber { get; set; }

        /// <summary>
        /// pagesize唯一，每页查询出来的个数。如果没传，默认传5
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// projectId唯一用于鉴权使用
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }
    }
}
