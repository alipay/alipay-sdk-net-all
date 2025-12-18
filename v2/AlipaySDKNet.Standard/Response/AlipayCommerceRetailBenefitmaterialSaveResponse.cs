using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRetailBenefitmaterialSaveResponse.
    /// </summary>
    public class AlipayCommerceRetailBenefitmaterialSaveResponse : AopResponse
    {
        /// <summary>
        /// 素材id
        /// </summary>
        [XmlElement("material_id")]
        public string MaterialId { get; set; }
    }
}
