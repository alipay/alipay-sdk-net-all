using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationServiceShopBindResponse.
    /// </summary>
    public class AlipayCommerceOperationServiceShopBindResponse : AopResponse
    {
        /// <summary>
        /// 序列化后业务返回信息，可能为空
        /// </summary>
        [XmlElement("response_data")]
        public string ResponseData { get; set; }

        /// <summary>
        /// 一次提交返回的唯一id
        /// </summary>
        [XmlElement("submit_record_id")]
        public string SubmitRecordId { get; set; }
    }
}
