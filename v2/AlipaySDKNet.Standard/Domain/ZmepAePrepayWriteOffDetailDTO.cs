using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZmepAePrepayWriteOffDetailDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ZmepAePrepayWriteOffDetailDTO : AopObject
    {
        /// <summary>
        /// 子单是否结清
        /// </summary>
        [XmlElement("is_clearance")]
        public bool IsClearance { get; set; }

        /// <summary>
        /// 主单号
        /// </summary>
        [XmlElement("order_num")]
        public string OrderNum { get; set; }

        /// <summary>
        /// 子单号
        /// </summary>
        [XmlElement("sub_order_num")]
        public string SubOrderNum { get; set; }
    }
}
