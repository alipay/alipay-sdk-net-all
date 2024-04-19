using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceCsplatformServicerecordBatchqueryResponse.
    /// </summary>
    public class AlipayIserviceCsplatformServicerecordBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 服务记录列表
        /// </summary>
        [XmlArray("value")]
        [XmlArrayItem("service_record_detail_v_o")]
        public List<ServiceRecordDetailVO> Value { get; set; }
    }
}
