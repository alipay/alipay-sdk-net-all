using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SellerSyncRentOrderExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SellerSyncRentOrderExtInfo : AopObject
    {
        /// <summary>
        /// 用户和租赁商合同上约定的租赁价格，单位为元
        /// </summary>
        [XmlElement("order_sign_price")]
        public string OrderSignPrice { get; set; }

        /// <summary>
        /// 用户租赁的结束时间
        /// </summary>
        [XmlElement("rent_end_time")]
        public string RentEndTime { get; set; }

        /// <summary>
        /// 租赁的模式：到期归还/到期即送/到期买断
        /// </summary>
        [XmlElement("rent_mode")]
        public string RentMode { get; set; }

        /// <summary>
        /// 用户租赁开始的时间
        /// </summary>
        [XmlElement("rent_start_time")]
        public string RentStartTime { get; set; }
    }
}
