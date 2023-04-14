using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryPerformOrderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryPerformOrderQueryModel : AopObject
    {
        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }
    }
}
