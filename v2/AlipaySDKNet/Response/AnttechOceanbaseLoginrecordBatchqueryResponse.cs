using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbaseLoginrecordBatchqueryResponse.
    /// </summary>
    public class AnttechOceanbaseLoginrecordBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 登录记录列表
        /// </summary>
        [XmlArray("login_records")]
        [XmlArrayItem("login_record_d_t_o")]
        public List<LoginRecordDTO> LoginRecords { get; set; }
    }
}
