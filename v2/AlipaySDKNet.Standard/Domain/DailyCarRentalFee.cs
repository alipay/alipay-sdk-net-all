using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DailyCarRentalFee Data Structure.
    /// </summary>
    [Serializable]
    public class DailyCarRentalFee : AopObject
    {
        /// <summary>
        /// 当日租金的金额，单位为分，注意金额是优惠前的
        /// </summary>
        [XmlElement("rent_fee")]
        public long RentFee { get; set; }

        /// <summary>
        /// 租车的时间（只需要精确到日）
        /// </summary>
        [XmlElement("rental_date")]
        public string RentalDate { get; set; }
    }
}
