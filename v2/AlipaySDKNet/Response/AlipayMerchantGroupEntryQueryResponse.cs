using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantGroupEntryQueryResponse.
    /// </summary>
    public class AlipayMerchantGroupEntryQueryResponse : AopResponse
    {
        /// <summary>
        /// 申请单状态
        /// </summary>
        [XmlElement("biz_status")]
        public string BizStatus { get; set; }

        /// <summary>
        /// 绑定账号uid
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 绑定账号uid
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }
    }
}
