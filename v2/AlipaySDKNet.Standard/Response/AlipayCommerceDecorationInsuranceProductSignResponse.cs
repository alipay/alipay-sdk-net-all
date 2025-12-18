using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceDecorationInsuranceProductSignResponse.
    /// </summary>
    public class AlipayCommerceDecorationInsuranceProductSignResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("sign_product_list")]
        [XmlArrayItem("sign_product_v_o")]
        public List<SignProductVO> SignProductList { get; set; }
    }
}
