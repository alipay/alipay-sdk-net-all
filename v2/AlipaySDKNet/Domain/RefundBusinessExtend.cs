using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RefundBusinessExtend Data Structure.
    /// </summary>
    [Serializable]
    public class RefundBusinessExtend : AopObject
    {
        /// <summary>
        /// 退款机构咨询
        /// </summary>
        [XmlElement("refund_inst_consult")]
        public string RefundInstConsult { get; set; }
    }
}
