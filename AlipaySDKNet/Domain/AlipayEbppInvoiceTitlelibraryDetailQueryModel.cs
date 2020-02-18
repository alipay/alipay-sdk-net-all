using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceTitlelibraryDetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceTitlelibraryDetailQueryModel : AopObject
    {
        /// <summary>
        /// 企业名称
        /// </summary>
        [XmlElement("title_name")]
        public string TitleName { get; set; }
    }
}
