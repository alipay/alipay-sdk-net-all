using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarMemberInfoSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarMemberInfoSyncModel : AopObject
    {
        /// <summary>
        /// 会员ID
        /// </summary>
        [XmlElement("card_id")]
        public string CardId { get; set; }

        /// <summary>
        /// true代表是关闭 不传和false 代表开通
        /// </summary>
        [XmlElement("closed")]
        public bool Closed { get; set; }

        /// <summary>
        /// 会员卡发放时间
        /// </summary>
        [XmlElement("issuance_date")]
        public string IssuanceDate { get; set; }

        /// <summary>
        /// 业务发生时间，即同步会员信息的时间
        /// </summary>
        [XmlElement("occur_time")]
        public string OccurTime { get; set; }

        /// <summary>
        /// 会员卡生效时间
        /// </summary>
        [XmlElement("open_date")]
        public string OpenDate { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 运营商侧用户ID
        /// </summary>
        [XmlElement("operator_uid")]
        public string OperatorUid { get; set; }

        /// <summary>
        /// 会员购买时间
        /// </summary>
        [XmlElement("purchase_time")]
        public string PurchaseTime { get; set; }

        /// <summary>
        /// 场景ID: 1:（charging）充电
        /// </summary>
        [XmlElement("scene_id")]
        public long SceneId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 会员卡失效时间
        /// </summary>
        [XmlElement("valid_date")]
        public string ValidDate { get; set; }
    }
}
