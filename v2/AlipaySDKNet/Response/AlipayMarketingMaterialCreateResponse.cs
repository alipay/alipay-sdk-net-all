using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingMaterialCreateResponse.
    /// </summary>
    public class AlipayMarketingMaterialCreateResponse : AopResponse
    {
        /// <summary>
        /// 素材ID。
        /// </summary>
        [XmlElement("material_id")]
        public string MaterialId { get; set; }
    }
}
