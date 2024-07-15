using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentPriceDetail Data Structure.
    /// </summary>
    [Serializable]
    public class RentPriceDetail : AopObject
    {
        /// <summary>
        /// 买断价格。单位元，精度分。
        /// </summary>
        [XmlElement("buyout_price")]
        public string BuyoutPrice { get; set; }

        /// <summary>
        /// 押金。单位元，精度分。
        /// </summary>
        [XmlElement("deposit_price")]
        public string DepositPrice { get; set; }

        /// <summary>
        /// 尾期租金。单位元，精度分。
        /// </summary>
        [XmlElement("finish_real_rent_price")]
        public string FinishRealRentPrice { get; set; }

        /// <summary>
        /// 首期租金。单位元，精度分。
        /// </summary>
        [XmlElement("initial_rent_price")]
        public string InitialRentPrice { get; set; }

        /// <summary>
        /// 租赁期数，单位：期
        /// </summary>
        [XmlElement("period_num")]
        public long PeriodNum { get; set; }

        /// <summary>
        /// 每期租金。单位元，精度分。
        /// </summary>
        [XmlElement("period_real_rent_price")]
        public string PeriodRealRentPrice { get; set; }

        /// <summary>
        /// 预授权金额。单位元，精度分。
        /// </summary>
        [XmlElement("pre_authorization_amount")]
        public string PreAuthorizationAmount { get; set; }

        /// <summary>
        /// 实付总金额。单位元，精度分。
        /// </summary>
        [XmlElement("real_pay_amount")]
        public string RealPayAmount { get; set; }

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
