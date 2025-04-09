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
        /// 租赁的模式：到期归还/到期即送/到期买断
        /// </summary>
        [XmlElement("rent_mode")]
        public string RentMode { get; set; }
    }
}
