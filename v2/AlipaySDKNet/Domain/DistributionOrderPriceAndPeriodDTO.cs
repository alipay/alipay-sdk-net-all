using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DistributionOrderPriceAndPeriodDTO Data Structure.
    /// </summary>
    [Serializable]
    public class DistributionOrderPriceAndPeriodDTO : AopObject
    {
        /// <summary>
        /// 押金，单位为元
        /// </summary>
        [XmlElement("deposit_price")]
        public string DepositPrice { get; set; }

        /// <summary>
        /// 运费，单位为元
        /// </summary>
        [XmlElement("freight")]
        public string Freight { get; set; }

        /// <summary>
        /// 租期结束时间
        /// </summary>
        [XmlElement("rent_end_time")]
        public string RentEndTime { get; set; }

        /// <summary>
        /// 租金，当前场景是首期租金，单位为元
        /// </summary>
        [XmlElement("rent_price")]
        public string RentPrice { get; set; }

        /// <summary>
        /// 租期开始时间
        /// </summary>
        [XmlElement("rent_start_time")]
        public string RentStartTime { get; set; }
    }
}
