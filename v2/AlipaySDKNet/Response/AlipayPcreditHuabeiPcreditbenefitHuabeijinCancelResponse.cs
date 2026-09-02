using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiPcreditbenefitHuabeijinCancelResponse.
    /// </summary>
    public class AlipayPcreditHuabeiPcreditbenefitHuabeijinCancelResponse : AopResponse
    {
        /// <summary>
        /// 活动流水id，原样返回
        /// </summary>
        [XmlElement("activity_order_id")]
        public string ActivityOrderId { get; set; }

        /// <summary>
        /// 不同的业务码表示在花呗侧业务处理过程中的不同状态
        /// </summary>
        [XmlElement("hb_biz_code")]
        public string HbBizCode { get; set; }

        /// <summary>
        /// 商家操作流水唯一
        /// </summary>
        [XmlElement("operation_seq_id")]
        public string OperationSeqId { get; set; }

        /// <summary>
        /// 商家业务单号，原样返回
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
