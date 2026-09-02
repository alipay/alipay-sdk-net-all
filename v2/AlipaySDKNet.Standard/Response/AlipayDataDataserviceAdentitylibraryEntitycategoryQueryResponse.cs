using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdentitylibraryEntitycategoryQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdentitylibraryEntitycategoryQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("open_product_category")]
        public List<OpenProductCategory> Result { get; set; }
    }
}
