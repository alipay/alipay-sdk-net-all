using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZmEpAePrepayExtParam Data Structure.
    /// </summary>
    [Serializable]
    public class ZmEpAePrepayExtParam : AopObject
    {
        /// <summary>
        /// 审核单创建时间戳
        /// </summary>
        [XmlElement("gmt_audit")]
        public string GmtAudit { get; set; }

        /// <summary>
        /// 订单支付时间戳
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 订单发货时间戳
        /// </summary>
        [XmlElement("ship_time")]
        public string ShipTime { get; set; }
    }
}
