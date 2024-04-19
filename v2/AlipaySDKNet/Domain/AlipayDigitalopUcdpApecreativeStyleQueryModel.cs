using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDigitalopUcdpApecreativeStyleQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDigitalopUcdpApecreativeStyleQueryModel : AopObject
    {
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
        /// 风格图片的行业信息。通过行业信息来查询图片。
        /// </summary>
        [XmlElement("profession")]
        public string Profession { get; set; }

        /// <summary>
        /// projectId唯一用于鉴权使用
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }
    }
}
