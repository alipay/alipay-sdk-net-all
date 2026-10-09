using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ParkingChargeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ParkingChargeInfo : AopObject
    {
        /// <summary>
        /// 计费金额；单位元；
        /// </summary>
        [XmlElement("charge_fee")]
        public string ChargeFee { get; set; }

        /// <summary>
        /// START_CHARGING：开始计费 FEE_INCREASE：费用增加 TO_TOP：日封顶
        /// </summary>
        [XmlElement("charge_node")]
        public string ChargeNode { get; set; }

        /// <summary>
        /// 开始计费或者费用增加的时间；传东八区时间；
        /// </summary>
        [XmlElement("charge_time")]
        public string ChargeTime { get; set; }
    }
}
