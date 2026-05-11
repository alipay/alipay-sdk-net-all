using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationServiceApplyResponse.
    /// </summary>
    public class AlipayCommerceOperationServiceApplyResponse : AopResponse
    {
        /// <summary>
        /// 报名记录id
        /// </summary>
        [XmlElement("apply_record_id")]
        public string ApplyRecordId { get; set; }

        /// <summary>
        /// 序列化后的报名出参信息
        /// </summary>
        [XmlElement("response_data")]
        public string ResponseData { get; set; }
    }
}
