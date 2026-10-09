using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TransferBillkey Data Structure.
    /// </summary>
    [Serializable]
    public class TransferBillkey : AopObject
    {
        /// <summary>
        /// 户号信息
        /// </summary>
        [XmlElement("bill_key")]
        public string BillKey { get; set; }

        /// <summary>
        /// 户号所属的出账机构
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }
    }
}
