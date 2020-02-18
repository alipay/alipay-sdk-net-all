using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceTitlelibraryListQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceTitlelibraryListQueryModel : AopObject
    {
        /// <summary>
        /// 模糊查询的抬头名称
        /// </summary>
        [XmlElement("title_simple_name")]
        public string TitleSimpleName { get; set; }
    }
}
