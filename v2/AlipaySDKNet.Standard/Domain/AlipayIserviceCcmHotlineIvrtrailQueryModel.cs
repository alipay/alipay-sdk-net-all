using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCcmHotlineIvrtrailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCcmHotlineIvrtrailQueryModel : AopObject
    {
        /// <summary>
        /// 123
        /// </summary>
        [XmlElement("contact_id")]
        public string ContactId { get; set; }

        /// <summary>
        /// 查询结果的页码，起始值为 1，默认值为 1
        /// </summary>
        [XmlElement("page_number")]
        public long PageNumber { get; set; }

        /// <summary>
        /// 查询结果的页大小，起始值为 10，默认值为 10
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
