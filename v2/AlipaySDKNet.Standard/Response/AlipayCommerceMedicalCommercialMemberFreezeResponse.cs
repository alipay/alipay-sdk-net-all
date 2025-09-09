using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalCommercialMemberFreezeResponse.
    /// </summary>
    public class AlipayCommerceMedicalCommercialMemberFreezeResponse : AopResponse
    {
        /// <summary>
        /// 外部商户商品ID
        /// </summary>
        [XmlElement("out_product_id")]
        public string OutProductId { get; set; }
    }
}
