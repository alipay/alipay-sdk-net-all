using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiCateringPosMaterialDeleteResponse.
    /// </summary>
    public class KoubeiCateringPosMaterialDeleteResponse : AopResponse
    {
        /// <summary>
        /// 配料id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }
    }
}
