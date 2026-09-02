using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationShopDeviceCreateResponse.
    /// </summary>
    public class AlipayCommerceOperationShopDeviceCreateResponse : AopResponse
    {
        /// <summary>
        /// 受理成功时返回，可用于问题排查和对账
        /// </summary>
        [XmlElement("submission_no")]
        public string SubmissionNo { get; set; }
    }
}
