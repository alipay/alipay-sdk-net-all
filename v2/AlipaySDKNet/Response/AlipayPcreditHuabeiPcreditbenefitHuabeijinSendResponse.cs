using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiPcreditbenefitHuabeijinSendResponse.
    /// </summary>
    public class AlipayPcreditHuabeiPcreditbenefitHuabeijinSendResponse : AopResponse
    {
        /// <summary>
        /// 用户发奖活动调用成功之后给用户的单据id，用于后续的变更操作
        /// </summary>
        [XmlElement("activity_order_id")]
        public string ActivityOrderId { get; set; }

        /// <summary>
        /// 计算后的待领取花呗金数量
        /// </summary>
        [XmlElement("calculated_amount")]
        public long CalculatedAmount { get; set; }

        /// <summary>
        /// 不同的业务码表示在花呗侧业务处理过程中的不同状态
        /// </summary>
        [XmlElement("hb_biz_code")]
        public string HbBizCode { get; set; }

        /// <summary>
        /// 输入中的外部业务单据，原样返回
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// HBMT_EXCHANGE_GOLDEN_POINT描述商户对接的待领取花呗金，也可能是直接入账的花呗金，看具体的权益
        /// </summary>
        [XmlElement("product_id")]
        public string ProductId { get; set; }
    }
}
