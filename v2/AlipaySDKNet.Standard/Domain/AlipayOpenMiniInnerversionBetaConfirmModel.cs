using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerversionBetaConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerversionBetaConfirmModel : AopObject
    {
        /// <summary>
        /// 业务来源
        /// </summary>
        [XmlElement("app_origin")]
        public string AppOrigin { get; set; }

        /// <summary>
        /// 拒绝理由
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 小程序ID，仅特殊场景使用，普通业务方无需关注该参数
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 操作：pass/reject。接受或者拒绝
        /// </summary>
        [XmlElement("operate")]
        public string Operate { get; set; }

        /// <summary>
        /// 小程序所属PID
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 要确认邀测结果的插件appid
        /// </summary>
        [XmlElement("plugin_id")]
        public string PluginId { get; set; }
    }
}
