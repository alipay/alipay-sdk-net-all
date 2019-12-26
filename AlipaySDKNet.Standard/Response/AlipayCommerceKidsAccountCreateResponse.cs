using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceKidsAccountCreateResponse.
    /// </summary>
    public class AlipayCommerceKidsAccountCreateResponse : AopResponse
    {
        /// <summary>
        /// 儿童唯一id
        /// </summary>
        [XmlElement("child_id")]
        public string ChildId { get; set; }
    }
}
