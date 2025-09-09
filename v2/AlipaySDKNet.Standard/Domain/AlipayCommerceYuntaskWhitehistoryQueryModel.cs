using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceYuntaskWhitehistoryQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceYuntaskWhitehistoryQueryModel : AopObject
    {
        /// <summary>
        /// 第几页，分页使用
        /// </summary>
        [XmlElement("page")]
        public long Page { get; set; }

        /// <summary>
        /// 每页数量，分页使用，单位个
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
