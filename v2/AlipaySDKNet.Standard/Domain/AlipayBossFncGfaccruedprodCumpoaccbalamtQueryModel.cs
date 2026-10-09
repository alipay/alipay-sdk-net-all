using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncGfaccruedprodCumpoaccbalamtQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncGfaccruedprodCumpoaccbalamtQueryModel : AopObject
    {
        /// <summary>
        /// 会记月份
        /// </summary>
        [XmlElement("account_period")]
        public string AccountPeriod { get; set; }

        /// <summary>
        /// 采购系统PO单号
        /// </summary>
        [XmlElement("po_no")]
        public string PoNo { get; set; }
    }
}
