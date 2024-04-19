using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceSportsVirtualprizeTemplateSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceSportsVirtualprizeTemplateSyncModel : AopObject
    {
        /// <summary>
        /// true:点击虚拟奖品详情，跳转到三方详情页 false:点击虚拟奖品详情，在支付宝文体展示详情
        /// </summary>
        [XmlElement("action_open")]
        public bool ActionOpen { get; set; }

        /// <summary>
        /// 未获得奖品时，去获取按钮配置的跳转链接
        /// </summary>
        [XmlElement("action_url")]
        public string ActionUrl { get; set; }

        /// <summary>
        /// 参考值：跑步线上赛：online_game；跑量挑战：regular_challenge
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 详情页已获得时彩色图片url,图片最大2M
        /// </summary>
        [XmlElement("detail_picture")]
        public string DetailPicture { get; set; }

        /// <summary>
        /// 详情页未获得时的灰色图片url，图片最大2M
        /// </summary>
        [XmlElement("detail_unreceived_picture")]
        public string DetailUnreceivedPicture { get; set; }

        /// <summary>
        /// 详情跳转连接
        /// </summary>
        [XmlElement("detail_url")]
        public string DetailUrl { get; set; }

        /// <summary>
        /// 外部奖品id+appid唯一
        /// </summary>
        [XmlElement("out_prize_id")]
        public string OutPrizeId { get; set; }

        /// <summary>
        /// 图片url,图片最大2M
        /// </summary>
        [XmlElement("picture")]
        public string Picture { get; set; }

        /// <summary>
        /// 奖品名称
        /// </summary>
        [XmlElement("prize_name")]
        public string PrizeName { get; set; }

        /// <summary>
        /// MEDAL：虚拟奖牌，CERTIFICATE：电子证书
        /// </summary>
        [XmlElement("prize_type")]
        public string PrizeType { get; set; }

        /// <summary>
        /// 用户领取奖品操作的配置，默认值为不需要用户手动领取即直接发放给用户，"receive"为会在用户获得但是还没领取奖品的时候主动弹出领取勋章的页面
        /// </summary>
        [XmlElement("receive_type")]
        public string ReceiveType { get; set; }

        /// <summary>
        /// 奖品获取规则文案
        /// </summary>
        [XmlElement("rule_desc")]
        public string RuleDesc { get; set; }

        /// <summary>
        /// 分享奖品时图片中展示的文案
        /// </summary>
        [XmlElement("share_memo")]
        public string ShareMemo { get; set; }

        /// <summary>
        /// 分享奖品时图片中展示的文案
        /// </summary>
        [XmlElement("share_title")]
        public string ShareTitle { get; set; }

        /// <summary>
        /// 状态，0：下线，1：上线
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 未获得时的灰色图片url,图片最大2M
        /// </summary>
        [XmlElement("unreceived_picture")]
        public string UnreceivedPicture { get; set; }

        /// <summary>
        /// 奖品对用户可见的配置，默认值为空表示未获取奖品的用户可见，"have"为拥有奖品的用户才可见(非have时unreceived_picture、detail_unreceived_picture必填)
        /// </summary>
        [XmlElement("visible_type")]
        public string VisibleType { get; set; }
    }
}
