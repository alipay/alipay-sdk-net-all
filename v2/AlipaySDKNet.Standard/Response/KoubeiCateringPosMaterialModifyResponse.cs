using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiCateringPosMaterialModifyResponse.
    /// </summary>
    public class KoubeiCateringPosMaterialModifyResponse : AopResponse
    {
        /// <summary>
        /// 配料id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }
    }
}
