using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserMpointPreconsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserMpointPreconsultModel : AopObject
    {
        /// <summary>
        /// 业务子场景，由支付宝侧分配，在积分发放场景下要求必传
        /// </summary>
        [XmlElement("biz_sub_scene")]
        public string BizSubScene { get; set; }

        /// <summary>
        /// 业务子类型，由支付宝侧分配
        /// </summary>
        [XmlElement("biz_sub_type")]
        public string BizSubType { get; set; }

        /// <summary>
        /// 业务类型，由支付宝侧分配
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 用户标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 目标操作的积分数
        /// </summary>
        [XmlElement("point")]
        public string Point { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
