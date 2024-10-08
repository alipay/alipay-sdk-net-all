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
        /// 续租总期数，1-12的整数，包含边界值
        /// </summary>
        [XmlElement("addon_period_num")]
        public string AddonPeriodNum { get; set; }

        /// <summary>
        /// 续租总金额，单位元
        /// </summary>
        [XmlElement("addon_real_rent_price")]
        public string AddonRealRentPrice { get; set; }

        /// <summary>
        /// 到期买断金，支持到期买断场景，回传到期买断金；单位：元，精确到小数点后两位；
        /// </summary>
        [XmlElement("buyout_price")]
        public string BuyoutPrice { get; set; }

        /// <summary>
        /// 押金金额，单位元
        /// </summary>
        [XmlElement("deposit_price")]
        public string DepositPrice { get; set; }

        /// <summary>
        /// 尾期租金用在非每期分期租金一致场景，例如一笔订单总金额100，首期33.33，每期33.33，尾期33.34，单位元
        /// </summary>
        [XmlElement("finish_real_rent_price")]
        public string FinishRealRentPrice { get; set; }

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

        /// <summary>
        /// 租期结束时间
        /// </summary>
        [XmlElement("rent_end_time")]
        public string RentEndTime { get; set; }

        /// <summary>
        /// 租期开始时间
        /// </summary>
        [XmlElement("rent_start_time")]
        public string RentStartTime { get; set; }
    }
}
