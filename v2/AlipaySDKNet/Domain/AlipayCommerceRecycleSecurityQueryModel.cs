using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRecycleSecurityQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRecycleSecurityQueryModel : AopObject
    {
        /// <summary>
        /// 风险咨询主体设备号
        /// </summary>
        [XmlElement("apdidtoken")]
        public string Apdidtoken { get; set; }

        /// <summary>
        /// 用来标识咨询场景，错误的传入业务场景可能会导致错误的咨询结果！ valueRecycle 有价回收 noValueRecycle 无价回收 blackOrderSync 黑名单回流 petRecycle 宠物领养咨询
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 风险咨询主体身份证号，非必选，有该字段风险结果更可靠。
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 风险咨询主体用户手机号
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 风险咨询主体的支付宝账号
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 预估回收价格，单位元。
        /// </summary>
        [XmlElement("order_amount")]
        public string OrderAmount { get; set; }

        /// <summary>
        /// 下单时间，标准时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 风险咨询主体的支付宝账号
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
