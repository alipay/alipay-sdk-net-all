using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceWithholdTaskQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceWithholdTaskQueryModel : AopObject
    {
        /// <summary>
        /// 外部业务单号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 代扣任务ID
        /// </summary>
        [XmlElement("withhold_no")]
        public string WithholdNo { get; set; }
    }
}
