using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiPcreditbenefitFuncardassertReturnResponse.
    /// </summary>
    public class AlipayPcreditHuabeiPcreditbenefitFuncardassertReturnResponse : AopResponse
    {
        /// <summary>
        /// 实际扣的花呗金个数，花呗金单位个
        /// </summary>
        [XmlElement("actual_point")]
        public long ActualPoint { get; set; }

        /// <summary>
        /// 业务编号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 扣减状态值
        /// </summary>
        [XmlElement("decrease_status")]
        public string DecreaseStatus { get; set; }

        /// <summary>
        /// 单据号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
