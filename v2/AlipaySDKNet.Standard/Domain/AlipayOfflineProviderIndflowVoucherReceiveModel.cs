using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderIndflowVoucherReceiveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderIndflowVoucherReceiveModel : AopObject
    {
        /// <summary>
        /// 用户手机号
        /// </summary>
        [XmlElement("mobile_phone")]
        public string MobilePhone { get; set; }

        /// <summary>
        /// 发奖记录ID
        /// </summary>
        [XmlElement("record_id")]
        public string RecordId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("send_order_ids")]
        [XmlArrayItem("string")]
        public List<string> SendOrderIds { get; set; }
    }
}
