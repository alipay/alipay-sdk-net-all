using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationServiceDigitalpoiCreateResponse.
    /// </summary>
    public class AlipayCommerceOperationServiceDigitalpoiCreateResponse : AopResponse
    {
        /// <summary>
        /// 一次调用返回的提交记录id
        /// </summary>
        [XmlElement("submit_record_id")]
        public string SubmitRecordId { get; set; }
    }
}
