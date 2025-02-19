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
        /// 账单类型 当前字段已废弃(该参数已废弃，若继续上传，系统也不会消费该参数，存量业务不受影响)
        /// </summary>
        [XmlElement("bill_type")]
        public string BillType { get; set; }
    }
}
