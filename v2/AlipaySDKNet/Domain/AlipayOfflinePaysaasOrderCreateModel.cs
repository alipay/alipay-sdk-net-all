using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflinePaysaasOrderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflinePaysaasOrderCreateModel : AopObject
    {
        /// <summary>
        /// 收款订单投送N手持设备ID
        /// </summary>
        [XmlElement("biz_tid")]
        public string BizTid { get; set; }

        /// <summary>
        /// 服务商外部单号,外部实际使用单号
        /// </summary>
        [XmlElement("isv_out_order_no")]
        public string IsvOutOrderNo { get; set; }

        /// <summary>
        /// 单位为分，最大值为100000000分
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }
    }
}
