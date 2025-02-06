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
        /// 账单类型 当前字段已废弃(数字分行账单已经全部回迁，不需要这个字段来区分账单是50产出还是数分产出)
        /// </summary>
        [XmlElement("bill_type")]
        public string BillType { get; set; }
    }
}
