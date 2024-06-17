using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationRecycleBillingSyncResponse.
    /// </summary>
    public class AlipayCommerceOperationRecycleBillingSyncResponse : AopResponse
    {
        /// <summary>
        /// 是否传递成功
        /// </summary>
        [XmlElement("data")]
        public bool Data { get; set; }
    }
}
