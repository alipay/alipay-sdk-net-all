using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GroupMessageVO Data Structure.
    /// </summary>
    [Serializable]
    public class GroupMessageVO : AopObject
    {
        /// <summary>
        /// 优惠券消息内容模型，当消息类型(msg_type)选 "COUPON" 的时候，这个内容必须得填充
        /// </summary>
        [XmlElement("coupon_msg_content")]
        public CouponMsgVO CouponMsgContent { get; set; }

        /// <summary>
        /// 商品消息内容模型，当消息类型(msg_type)选 "GOODS" 的时候，这个内容必须得填充
        /// </summary>
        [XmlElement("goods_msg_content")]
        public GoodsMsgVO GoodsMsgContent { get; set; }

        /// <summary>
        /// 图片消息内容模型，当消息类型(msg_type)选 "IMAGE" 的时候，这个内容必须得填充
        /// </summary>
        [XmlElement("image_msg_content")]
        public ImageMsgVO ImageMsgContent { get; set; }

        /// <summary>
        /// 链接消息内容模型，当消息类型(msg_type) 选择"LINK"的时候，必须填充这个内容
        /// </summary>
        [XmlElement("link_msg_content")]
        public LinkMsgVO LinkMsgContent { get; set; }

        /// <summary>
        /// 群消息类型枚举，小程序消息:"APP"，图片消息:"IMAGE"，链接消息:"LINK"，纯文本消息:"TEXT"，优惠券消息:"COUPON"，商品消息:"GOODS"
        /// </summary>
        [XmlElement("msg_type")]
        public string MsgType { get; set; }

        /// <summary>
        /// 纯文本消息内容模型，当消息类型(msg_type)选 "TEXT" 的时候，这个内容必须得填充
        /// </summary>
        [XmlElement("text_msg_content")]
        public TextMsgVO TextMsgContent { get; set; }

        /// <summary>
        /// 小程序消息内容模型，当消息类型(msg_type)选 "APP" 的时候，这个内容必须得填充
        /// </summary>
        [XmlElement("tiny_app_msg_content")]
        public TinyAppMsgVO TinyAppMsgContent { get; set; }
    }
}
