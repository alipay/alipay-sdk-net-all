using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCliveConnectCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCliveConnectCreateModel : AopObject
    {
        /// <summary>
        /// 客户端类型
        /// </summary>
        [XmlElement("app_type")]
        public string AppType { get; set; }

        /// <summary>
        /// 浏览器信息
        /// </summary>
        [XmlElement("client_info")]
        public string ClientInfo { get; set; }

        /// <summary>
        /// 访客Ip地址
        /// </summary>
        [XmlElement("client_ip")]
        public string ClientIp { get; set; }

        /// <summary>
        /// 来源网页url，用于记录用户行为轨迹
        /// </summary>
        [XmlElement("enter_url")]
        public string EnterUrl { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext_values")]
        public string ExtValues { get; set; }

        /// <summary>
        /// 技能组ID
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 埋点服务路径id
        /// </summary>
        [XmlElement("path_id")]
        public string PathId { get; set; }

        /// <summary>
        /// 用户的优先级，如无特殊优先级，默认值为0
        /// </summary>
        [XmlElement("priority")]
        public string Priority { get; set; }

        /// <summary>
        /// 是否重连原始客服,如果重连，请传true
        /// </summary>
        [XmlElement("reconnect")]
        public string Reconnect { get; set; }

        /// <summary>
        /// 小二id:指定小二连接
        /// </summary>
        [XmlElement("server_id")]
        public string ServerId { get; set; }

        /// <summary>
        /// 一次服务的token，必须唯一，相当于本次服务的唯一标识
        /// </summary>
        [XmlElement("service_token")]
        public string ServiceToken { get; set; }

        /// <summary>
        /// 机器人会话id参数名称
        /// </summary>
        [XmlElement("session_uuid")]
        public string SessionUuid { get; set; }

        /// <summary>
        /// 访问DT的渠道 11:LINKS 12:HELLO_BIKE
        /// </summary>
        [XmlElement("src")]
        public string Src { get; set; }

        /// <summary>
        /// 访客uid
        /// </summary>
        [XmlElement("visitor_id")]
        public string VisitorId { get; set; }

        /// <summary>
        /// 访客名称
        /// </summary>
        [XmlElement("visitor_name")]
        public string VisitorName { get; set; }

        /// <summary>
        /// 访客类型，COMMON_VISITOR(普通登录访客)/ANONYMITY_VISITOR(匿名访客)
        /// </summary>
        [XmlElement("visitor_type")]
        public string VisitorType { get; set; }
    }
}
