using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoAichatMsgCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoAichatMsgCreateModel : AopObject
    {
        /// <summary>
        /// scene为直播时，需要商品id； scene为游戏GS时，需要聊天类型
        /// </summary>
        [XmlElement("biz_trans_data")]
        public string BizTransData { get; set; }

        /// <summary>
        /// 请求的聊天或提问消息
        /// </summary>
        [XmlElement("chat_query")]
        public string ChatQuery { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 业务侧针对单轮问答生成的唯一业务号，用来标记单轮对话
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 接入时的对话机器人id
        /// </summary>
        [XmlElement("robot_id")]
        public string RobotId { get; set; }

        /// <summary>
        /// 直播场景问答
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
