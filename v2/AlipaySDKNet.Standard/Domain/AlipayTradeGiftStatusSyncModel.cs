using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeGiftStatusSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeGiftStatusSyncModel : AopObject
    {
        /// <summary>
        /// 状态用于驱动礼物卡片展示的变化(accepted-已收下驱动高亮变灰、overdueNotReceived已过期驱动高亮变灰且提示过期未领取)
        /// </summary>
        [XmlElement("gift_status")]
        public string GiftStatus { get; set; }

        /// <summary>
        /// 用于标记支付宝送礼用户在应用下的唯一标识
        /// </summary>
        [XmlElement("giver_open_id")]
        public string GiverOpenId { get; set; }

        /// <summary>
        /// 用于标记送礼用户在淘宝应用下的唯一标识
        /// </summary>
        [XmlElement("giver_tb_open_id")]
        public string GiverTbOpenId { get; set; }

        /// <summary>
        /// 送礼人淘宝用户id
        /// </summary>
        [XmlElement("giver_tb_user_id")]
        public string GiverTbUserId { get; set; }

        /// <summary>
        /// 送礼用户支付宝的userId。
        /// </summary>
        [XmlElement("giver_user_id")]
        public string GiverUserId { get; set; }

        /// <summary>
        /// 会话id Base64编码
        /// </summary>
        [XmlElement("present_session_id")]
        public string PresentSessionId { get; set; }

        /// <summary>
        /// 用于标记支付宝收礼用户在应用下的唯一标识
        /// </summary>
        [XmlElement("recipient_open_id")]
        public string RecipientOpenId { get; set; }

        /// <summary>
        /// 收礼用户支付宝的userId。
        /// </summary>
        [XmlElement("recipient_user_id")]
        public string RecipientUserId { get; set; }

        /// <summary>
        /// 关联订单组id,一送多收的场景
        /// </summary>
        [XmlElement("tb_og_id")]
        public string TbOgId { get; set; }

        /// <summary>
        /// 淘宝订单id
        /// </summary>
        [XmlElement("tb_order_id")]
        public string TbOrderId { get; set; }

        /// <summary>
        /// 淘宝埋点参数
        /// </summary>
        [XmlElement("ut_sk")]
        public string UtSk { get; set; }

        /// <summary>
        /// 淘宝前端SDK版本生成消息卡片的时候需要带给会话
        /// </summary>
        [XmlElement("wx_js_min_version")]
        public string WxJsMinVersion { get; set; }
    }
}
