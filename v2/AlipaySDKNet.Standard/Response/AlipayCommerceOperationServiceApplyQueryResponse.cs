using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationServiceApplyQueryResponse.
    /// </summary>
    public class AlipayCommerceOperationServiceApplyQueryResponse : AopResponse
    {
        /// <summary>
        /// 报名记录id
        /// </summary>
        [XmlElement("apply_record_id")]
        public string ApplyRecordId { get; set; }

        /// <summary>
        /// 报名后产生的业务信息，是序列化字符串，具体视不同业务而定。
        /// </summary>
        [XmlElement("response_data")]
        public string ResponseData { get; set; }
    }
}
