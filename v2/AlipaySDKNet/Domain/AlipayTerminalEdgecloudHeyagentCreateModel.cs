using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTerminalEdgecloudHeyagentCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTerminalEdgecloudHeyagentCreateModel : AopObject
    {
        /// <summary>
        /// 是否是acr
        /// </summary>
        [XmlElement("acr")]
        public string Acr { get; set; }

        /// <summary>
        /// acr业务
        /// </summary>
        [XmlElement("acr_sub_biz_type")]
        public string AcrSubBizType { get; set; }

        /// <summary>
        /// 云机器相关
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [XmlElement("application_id")]
        public string ApplicationId { get; set; }

        /// <summary>
        /// 云机器相关
        /// </summary>
        [XmlElement("biz_name")]
        public string BizName { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 任务超时时间“1200”表示1200秒。在taskInfo中。与consultParams平级
        /// </summary>
        [XmlElement("task_time_out_thres")]
        public string TaskTimeOutThres { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }

        /// <summary>
        /// YYzVEX8a/uYDAEZLjpYWwMro 用户设备的唯一标识
        /// </summary>
        [XmlElement("utdid")]
        public string Utdid { get; set; }
    }
}
