using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsCouponInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InsCouponInfo : AopObject
    {
        /// <summary>
        /// 权益关联的券id，权益查询接口返回的权益信息中有，使用该值传值
        /// </summary>
        [XmlElement("bind_voucher_id")]
        public string BindVoucherId { get; set; }

        /// <summary>
        /// 权益配置id，权益查询接口返回的权益信息中有，使用该值传值
        /// </summary>
        [XmlElement("coupon_config_id")]
        public string CouponConfigId { get; set; }

        /// <summary>
        /// 权益发放流水id，权益查询接口返回的权益信息中有，使用该值传值
        /// </summary>
        [XmlElement("coupon_send_flow_id")]
        public string CouponSendFlowId { get; set; }

        /// <summary>
        /// 权益状态
        /// </summary>
        [XmlElement("coupon_status")]
        public string CouponStatus { get; set; }

        /// <summary>
        /// 权益类型
        /// </summary>
        [XmlElement("coupon_type")]
        public string CouponType { get; set; }

        /// <summary>
        /// 权益有效期开始时间
        /// </summary>
        [XmlElement("gmt_active")]
        public string GmtActive { get; set; }

        /// <summary>
        /// 权益有效期结束时间
        /// </summary>
        [XmlElement("gmt_expired")]
        public string GmtExpired { get; set; }
    }
}
