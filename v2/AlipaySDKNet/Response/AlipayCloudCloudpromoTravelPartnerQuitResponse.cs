using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoTravelPartnerQuitResponse.
    /// </summary>
    public class AlipayCloudCloudpromoTravelPartnerQuitResponse : AopResponse
    {
        /// <summary>
        /// 伴游状态
        /// </summary>
        [XmlElement("assist_status")]
        public string AssistStatus { get; set; }

        /// <summary>
        /// 伴游记录ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }
    }
}
