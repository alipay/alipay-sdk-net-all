using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbaseEntityroleHuaweimpBatchqueryResponse.
    /// </summary>
    public class AnttechOceanbaseEntityroleHuaweimpBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// [{"passportId":"test1","customerId":"test1","customerName":"test"}]
        /// </summary>
        [XmlArray("huawei_buyer_info_list")]
        [XmlArrayItem("huawei_m_p_buyer_d_t_o")]
        public List<HuaweiMPBuyerDTO> HuaweiBuyerInfoList { get; set; }
    }
}
