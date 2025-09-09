using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCcmMiniappServiceurlQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCcmMiniappServiceurlQueryModel : AopObject
    {
        /// <summary>
        /// 可选，用于数据统计分析，该字段会经过白名单校验，未通过校验会忽略。使用该字段前请联系接口负责人。
        /// </summary>
        [XmlElement("biz_tag")]
        public string BizTag { get; set; }

        /// <summary>
        /// 是否强制使用支付宝tab4消息（客服号）聊天窗，否则根据后台配置查询。聊天窗有客服号和小程序聊天窗两种形态。
        /// </summary>
        [XmlElement("force_use_bc_chat")]
        public bool ForceUseBcChat { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
