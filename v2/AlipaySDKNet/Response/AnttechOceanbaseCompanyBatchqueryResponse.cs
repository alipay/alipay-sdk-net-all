using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbaseCompanyBatchqueryResponse.
    /// </summary>
    public class AnttechOceanbaseCompanyBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 企业列表
        /// </summary>
        [XmlArray("company_list")]
        [XmlArrayItem("o_b_company_d_t_o")]
        public List<OBCompanyDTO> CompanyList { get; set; }
    }
}
