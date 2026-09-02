using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationServiceModifyResponse.
    /// </summary>
    public class AlipayCommerceOperationServiceModifyResponse : AopResponse
    {
        /// <summary>
        /// 序列化后的报名出参信息
        /// </summary>
        [XmlElement("response_data")]
        public string ResponseData { get; set; }

        /// <summary>
        /// 报名记录id
        /// </summary>
        [XmlElement("submit_record_id")]
        public string SubmitRecordId { get; set; }
    }
}
