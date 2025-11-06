using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbaseObglobalLeadproducttypeQueryResponse.
    /// </summary>
    public class AnttechOceanbaseObglobalLeadproducttypeQueryResponse : AopResponse
    {
        /// <summary>
        /// 结果对象
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("leads_product_type_d_t_o")]
        public List<LeadsProductTypeDTO> Result { get; set; }
    }
}
