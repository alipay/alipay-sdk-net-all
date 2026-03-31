using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandChannelpoiCreateResponse.
    /// </summary>
    public class AntMerchantExpandChannelpoiCreateResponse : AopResponse
    {
        /// <summary>
        /// 申请单ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 进件所属阶段
        /// </summary>
        [XmlElement("progress")]
        public string Progress { get; set; }
    }
}
