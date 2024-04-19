using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiGoodsOrderSyncResponse.
    /// </summary>
    public class AlipayPcreditHuabeiGoodsOrderSyncResponse : AopResponse
    {
        /// <summary>
        /// 业务结果
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
