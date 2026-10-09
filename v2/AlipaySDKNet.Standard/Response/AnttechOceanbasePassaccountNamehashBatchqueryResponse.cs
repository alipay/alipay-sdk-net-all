using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbasePassaccountNamehashBatchqueryResponse.
    /// </summary>
    public class AnttechOceanbasePassaccountNamehashBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 返回的账号信息
        /// </summary>
        [XmlArray("records")]
        [XmlArrayItem("pass_account_name_hash_record_d_t_o")]
        public List<PassAccountNameHashRecordDTO> Records { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
