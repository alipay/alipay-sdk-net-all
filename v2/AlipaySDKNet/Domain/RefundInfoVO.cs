using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RefundInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class RefundInfoVO : AopObject
    {
        /// <summary>
        /// 退款记录
        /// </summary>
        [XmlArray("refund_list")]
        [XmlArrayItem("refund_record_v_o")]
        public List<RefundRecordVO> RefundList { get; set; }
    }
}
