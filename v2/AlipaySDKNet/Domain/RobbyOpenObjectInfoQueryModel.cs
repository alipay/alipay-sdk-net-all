using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RobbyOpenObjectInfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class RobbyOpenObjectInfoQueryModel : AopObject
    {
        /// <summary>
        /// 业务对象名称（如药品名），模糊匹配
        /// </summary>
        [XmlElement("biz_object_name")]
        public string BizObjectName { get; set; }

        /// <summary>
        /// 业务对象编号（如69码），精确匹配
        /// </summary>
        [XmlElement("biz_object_no")]
        public string BizObjectNo { get; set; }

        /// <summary>
        /// 对象库ID
        /// </summary>
        [XmlElement("object_library_id")]
        public string ObjectLibraryId { get; set; }

        /// <summary>
        /// 当前页
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
