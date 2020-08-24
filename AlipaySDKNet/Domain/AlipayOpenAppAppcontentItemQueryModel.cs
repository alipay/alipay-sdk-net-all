using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppAppcontentItemQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppAppcontentItemQueryModel : AopObject
    {
        /// <summary>
        /// 当前页码；大于0
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页查询数量；可选值：1到20
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
