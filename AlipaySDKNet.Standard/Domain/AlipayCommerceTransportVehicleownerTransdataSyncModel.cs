using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportVehicleownerTransdataSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportVehicleownerTransdataSyncModel : AopObject
    {
        /// <summary>
        /// 同步操作类型
        /// </summary>
        [XmlElement("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 同步数据
        /// </summary>
        [XmlElement("trans_data")]
        public string TransData { get; set; }

        /// <summary>
        /// 支付宝uid
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }
    }
}
