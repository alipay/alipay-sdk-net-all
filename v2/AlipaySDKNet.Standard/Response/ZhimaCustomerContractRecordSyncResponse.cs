using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCustomerContractRecordSyncResponse.
    /// </summary>
    public class ZhimaCustomerContractRecordSyncResponse : AopResponse
    {
        /// <summary>
        /// 本次存证记录的唯一标识
        /// </summary>
        [XmlElement("record_no")]
        public string RecordNo { get; set; }
    }
}
