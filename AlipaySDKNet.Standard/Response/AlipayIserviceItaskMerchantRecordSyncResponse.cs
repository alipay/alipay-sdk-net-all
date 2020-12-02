using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceItaskMerchantRecordSyncResponse.
    /// </summary>
    public class AlipayIserviceItaskMerchantRecordSyncResponse : AopResponse
    {
        /// <summary>
        /// 业务入参的biz_id
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
