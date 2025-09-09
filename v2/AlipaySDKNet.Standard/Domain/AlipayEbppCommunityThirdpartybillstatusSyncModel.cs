using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppCommunityThirdpartybillstatusSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppCommunityThirdpartybillstatusSyncModel : AopObject
    {
        /// <summary>
        /// 待缴账单通知用户 Uid 
        /// </summary>
        [XmlElement("alipay_uid")]
        public string AlipayUid { get; set; }

        /// <summary>
        /// 待缴账单业务流水号 通过该字段幂等。 相同服务商下传入相同 bizNo 视为相同请求。
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 待缴账单通知用户 Uid 对应的openUid (与alipayUid对应)
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 已缴费金额，正数 单位:分 如缴费 200.20 元，则传入 20020
        /// </summary>
        [XmlElement("paid_amount")]
        public long PaidAmount { get; set; }

        /// <summary>
        /// 支付单号
        /// </summary>
        [XmlElement("pay_no")]
        public string PayNo { get; set; }

        /// <summary>
        /// 账单状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
