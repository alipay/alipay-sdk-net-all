using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BillSyncExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BillSyncExtInfo : AopObject
    {
        /// <summary>
        /// 账单类型
        /// </summary>
        [XmlElement("order_pay_type")]
        public string OrderPayType { get; set; }
    }
}
