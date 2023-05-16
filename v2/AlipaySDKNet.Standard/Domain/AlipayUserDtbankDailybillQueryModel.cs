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
    }
}
