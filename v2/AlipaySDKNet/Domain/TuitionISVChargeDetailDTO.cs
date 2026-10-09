using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TuitionISVChargeDetailDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TuitionISVChargeDetailDTO : AopObject
    {
        /// <summary>
        /// 费用金额
        /// </summary>
        [XmlElement("fee_amount")]
        public TuitionMoneyDTO FeeAmount { get; set; }

        /// <summary>
        /// 费用名称
        /// </summary>
        [XmlElement("fee_name")]
        public string FeeName { get; set; }
    }
}
