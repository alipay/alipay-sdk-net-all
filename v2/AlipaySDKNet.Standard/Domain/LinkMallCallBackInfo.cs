using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LinkMallCallBackInfo Data Structure.
    /// </summary>
    [Serializable]
    public class LinkMallCallBackInfo : AopObject
    {
        /// <summary>
        /// 操作类型
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 业务ID
        /// </summary>
        [XmlElement("bizid")]
        public string Bizid { get; set; }

        /// <summary>
        /// 存储回调上下文信息
        /// </summary>
        [XmlElement("extinfo")]
        public string Extinfo { get; set; }

        /// <summary>
        /// linkedmall用户ID
        /// </summary>
        [XmlElement("lmuserid")]
        public string Lmuserid { get; set; }

        /// <summary>
        /// 优惠模板ID
        /// </summary>
        [XmlElement("promotionid")]
        public string Promotionid { get; set; }

        /// <summary>
        /// 优惠实例ID，对应拉菲返回的outerInstanceId
        /// </summary>
        [XmlElement("promotioninstanceid")]
        public string Promotioninstanceid { get; set; }

        /// <summary>
        /// 用户的淘宝ID
        /// </summary>
        [XmlElement("taobaoid")]
        public string Taobaoid { get; set; }

        /// <summary>
        /// Long ms的时间戳
        /// </summary>
        [XmlElement("time_stamp")]
        public string TimeStamp { get; set; }
    }
}
