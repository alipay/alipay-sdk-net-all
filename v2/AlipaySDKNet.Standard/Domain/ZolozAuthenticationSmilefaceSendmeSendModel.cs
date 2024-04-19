using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZolozAuthenticationSmilefaceSendmeSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZolozAuthenticationSmilefaceSendmeSendModel : AopObject
    {
        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 活动ID，用于发送优惠券
        /// </summary>
        [XmlElement("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 可通过线下刷脸获取
        /// </summary>
        [XmlElement("ftoken")]
        public string Ftoken { get; set; }

        /// <summary>
        /// 推送消息到用户钱包中，并打开该小程序
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 跳转到小程序内的页面
        /// </summary>
        [XmlElement("path")]
        public string Path { get; set; }
    }
}
