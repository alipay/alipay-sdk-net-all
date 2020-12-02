using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpOperationApplyResponse.
    /// </summary>
    public class AlipayOpenSpOperationApplyResponse : AopResponse
    {
        /// <summary>
        /// 支付宝操作批次号
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }
    }
}
