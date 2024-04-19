using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbasePassportBatchqueryResponse.
    /// </summary>
    public class AnttechOceanbasePassportBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 通行证列表
        /// </summary>
        [XmlArray("passport_details")]
        [XmlArrayItem("passport_detail_d_t_o")]
        public List<PassportDetailDTO> PassportDetails { get; set; }
    }
}
