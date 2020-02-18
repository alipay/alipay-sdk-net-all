using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotAdvertiserMaterialQueryResponse.
    /// </summary>
    public class AlipayCommerceIotAdvertiserMaterialQueryResponse : AopResponse
    {
        /// <summary>
        /// 物料id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 物料地址
        /// </summary>
        [XmlElement("material_url")]
        public string MaterialUrl { get; set; }
    }
}
