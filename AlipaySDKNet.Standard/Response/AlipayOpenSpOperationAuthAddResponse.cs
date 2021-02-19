using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpOperationAuthAddResponse.
    /// </summary>
    public class AlipayOpenSpOperationAuthAddResponse : AopResponse
    {
        /// <summary>
        /// 支付宝操作批次号
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }
    }
}
