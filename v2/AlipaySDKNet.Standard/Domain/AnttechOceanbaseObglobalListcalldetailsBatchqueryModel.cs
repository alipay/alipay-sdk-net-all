using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObglobalListcalldetailsBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObglobalListcalldetailsBatchqueryModel : AopObject
    {
        /// <summary>
        /// 查询呼叫记录详情列表请求体
        /// </summary>
        [XmlElement("list_call_detail_records_request")]
        public ListCallDetailRecordsRequest ListCallDetailRecordsRequest { get; set; }
    }
}
