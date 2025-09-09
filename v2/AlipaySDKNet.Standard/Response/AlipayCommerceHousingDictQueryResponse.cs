using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceHousingDictQueryResponse.
    /// </summary>
    public class AlipayCommerceHousingDictQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("enum_model_d_t_o")]
        public List<EnumModelDTO> List { get; set; }
    }
}
