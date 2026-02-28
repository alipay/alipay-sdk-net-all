using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BizInfoMap Data Structure.
    /// </summary>
    [Serializable]
    public class BizInfoMap : AopObject
    {
        /// <summary>
        /// 业务对象的数量
        /// </summary>
        [XmlElement("biz_count")]
        public long BizCount { get; set; }

        /// <summary>
        /// 业务对象标识，如药品 ID，69 码等
        /// </summary>
        [XmlElement("biz_object_no")]
        public string BizObjectNo { get; set; }

        /// <summary>
        /// 该业务对象标识所属对象库，必填
        /// </summary>
        [XmlElement("object_library_id")]
        public string ObjectLibraryId { get; set; }
    }
}
