using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbaseCustomerAliyuncustomerBatchqueryResponse.
    /// </summary>
    public class AnttechOceanbaseCustomerAliyuncustomerBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// [{"customerName":"test1","cid":"cid1","userId":"test2"}]
        /// </summary>
        [XmlArray("aliyun_customer_info_list")]
        [XmlArrayItem("aliyun_customer_info_d_t_o")]
        public List<AliyunCustomerInfoDTO> AliyunCustomerInfoList { get; set; }
    }
}
