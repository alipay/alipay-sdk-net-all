using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbaseObcustomercoreBatchuserentityQueryResponse.
    /// </summary>
    public class AnttechOceanbaseObcustomercoreBatchuserentityQueryResponse : AopResponse
    {
        /// <summary>
        /// 客户身份信息列表
        /// </summary>
        [XmlArray("customer_identity_list")]
        [XmlArrayItem("o_b_batch_customer_identity_d_t_o")]
        public List<OBBatchCustomerIdentityDTO> CustomerIdentityList { get; set; }
    }
}
