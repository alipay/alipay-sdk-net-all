using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCliveConnectCloseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCliveConnectCloseModel : AopObject
    {
        /// <summary>
        /// 若是会话已经建立，关闭时必须传该conversation_id来请求关闭。若未建立，传visitor_token来请求关闭。 visitor_token 和 conversation_id 不能同时为空。
        /// </summary>
        [XmlElement("conversation_id")]
        public string ConversationId { get; set; }

        /// <summary>
        /// 访问DT的渠道 11:LINKS 12:HELLO_BIKE
        /// </summary>
        [XmlElement("src")]
        public string Src { get; set; }

        /// <summary>
        /// DT端定义的访客token，标识唯一的访客，在connect成功的时候有给发起方返回。若是会话未建立，关闭时传该token进行关闭。visitor_token 和 conversation_id 不能同时为空。
        /// </summary>
        [XmlElement("visitor_token")]
        public string VisitorToken { get; set; }
    }
}
