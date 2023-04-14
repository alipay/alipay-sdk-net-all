using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniResourceUserdataQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniResourceUserdataQueryModel : AopObject
    {
        /// <summary>
        /// 插件appId
        /// </summary>
        [XmlElement("plugin_id")]
        public string PluginId { get; set; }

        /// <summary>
        /// 用户画像类别，可选值为：user_age(年龄)、user_gender(性别)、resident_city(城市)、active_hour(活跃时间-小时)
        /// </summary>
        [XmlElement("profile_type")]
        public string ProfileType { get; set; }

        /// <summary>
        /// 需要查询的日期，格式: yyyyMMdd
        /// </summary>
        [XmlElement("report_date")]
        public string ReportDate { get; set; }
    }
}
