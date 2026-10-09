using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceHousingNewhouseLayoutSaveResponse.
    /// </summary>
    public class AlipayCommerceHousingNewhouseLayoutSaveResponse : AopResponse
    {
        /// <summary>
        /// 内部户型id
        /// </summary>
        [XmlElement("layout_id")]
        public string LayoutId { get; set; }
    }
}
