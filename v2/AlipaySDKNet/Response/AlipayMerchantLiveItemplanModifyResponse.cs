using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantLiveItemplanModifyResponse.
    /// </summary>
    public class AlipayMerchantLiveItemplanModifyResponse : AopResponse
    {
        /// <summary>
        /// 针对操作结果的说明
        /// </summary>
        [XmlElement("msg_info")]
        public string MsgInfo { get; set; }
    }
}
