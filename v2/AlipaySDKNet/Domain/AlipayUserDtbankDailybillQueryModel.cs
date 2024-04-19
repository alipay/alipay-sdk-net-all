using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserDtbankDailybillQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserDtbankDailybillQueryModel : AopObject
    {
        /// <summary>
        /// 账单id
        /// </summary>
        [XmlElement("bill_id")]
        public string BillId { get; set; }

        /// <summary>
        /// 账单类型
        /// </summary>
        [XmlElement("bill_type")]
        public string BillType { get; set; }
    }
}
