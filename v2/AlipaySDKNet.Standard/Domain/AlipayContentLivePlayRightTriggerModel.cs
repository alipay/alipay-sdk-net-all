using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayContentLivePlayRightTriggerModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayContentLivePlayRightTriggerModel : AopObject
    {
        /// <summary>
        /// 支付宝直播间id
        /// </summary>
        [XmlElement("alipay_live_id")]
        public string AlipayLiveId { get; set; }

        /// <summary>
        /// 主播生活号id
        /// </summary>
        [XmlElement("anchor_public_id")]
        public string AnchorPublicId { get; set; }

        /// <summary>
        /// 直播奖品id，通过直播奖品系统配置获取
        /// </summary>
        [XmlElement("award_id")]
        public string AwardId { get; set; }

        /// <summary>
        /// 权益发放形式
        /// </summary>
        [XmlElement("deliver_type")]
        public string DeliverType { get; set; }

        /// <summary>
        /// 行业标识
        /// </summary>
        [XmlElement("domain")]
        public string Domain { get; set; }

        /// <summary>
        /// 外部业务id，由调用方传入
        /// </summary>
        [XmlElement("out_biz_id")]
        public string OutBizId { get; set; }

        /// <summary>
        /// 权益详情数据
        /// </summary>
        [XmlElement("right_detail")]
        public LivePlayRightDetail RightDetail { get; set; }

        /// <summary>
        /// 权益类型
        /// </summary>
        [XmlElement("right_type")]
        public string RightType { get; set; }

        /// <summary>
        /// 用户生活号id
        /// </summary>
        [XmlElement("user_public_id")]
        public string UserPublicId { get; set; }
    }
}
