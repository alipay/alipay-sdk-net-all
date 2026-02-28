using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceAftersaleorderConfirmtimeoutModifyResponse.
    /// </summary>
    public class AlipayCommerceAftersaleorderConfirmtimeoutModifyResponse : AopResponse
    {
        /// <summary>
        /// 售后单id
        /// </summary>
        [XmlElement("aftersales_id")]
        public string AftersalesId { get; set; }
    }
}
