using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsMarketingInscouponTriggerModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsMarketingInscouponTriggerModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("ext_params")]
        [XmlArrayItem("key_value_d_t_o")]
        public List<KeyValueDTO> ExtParams { get; set; }

        /// <summary>
        /// 权益实例
        /// </summary>
        [XmlElement("ins_coupon")]
        public InsCouponInfo InsCoupon { get; set; }

        /// <summary>
        /// 开发平台用户的唯一标识符
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 业务单号，业务逻辑中的幂等单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 触发时间
        /// </summary>
        [XmlElement("trigger_time")]
        public string TriggerTime { get; set; }

        /// <summary>
        /// 触发类型
        /// </summary>
        [XmlElement("trigger_type")]
        public string TriggerType { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
