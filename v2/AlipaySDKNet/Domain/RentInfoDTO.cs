using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RentInfoDTO : AopObject
    {
        /// <summary>
        /// 买断价，单位元
        /// </summary>
        [XmlElement("buyout_price")]
        public string BuyoutPrice { get; set; }

        /// <summary>
        /// 首期租金,单位元
        /// </summary>
        [XmlElement("initial_rent_price")]
        public string InitialRentPrice { get; set; }

        /// <summary>
        /// 期数，1-36的整数，包含边界值
        /// </summary>
        [XmlElement("period_num")]
        public long PeriodNum { get; set; }

        /// <summary>
        /// 每期租金，单位元
        /// </summary>
        [XmlElement("period_real_rent_price")]
        public string PeriodRealRentPrice { get; set; }
    }
}
