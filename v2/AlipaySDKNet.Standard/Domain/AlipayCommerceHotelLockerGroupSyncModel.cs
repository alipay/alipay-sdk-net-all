using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceHotelLockerGroupSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceHotelLockerGroupSyncModel : AopObject
    {
        /// <summary>
        /// 支付宝Pid
        /// </summary>
        [XmlElement("alipay_pid")]
        public string AlipayPid { get; set; }

        /// <summary>
        /// 小程序logo
        /// </summary>
        [XmlElement("app_logo")]
        public string AppLogo { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("bar_links")]
        [XmlArrayItem("bar_link_info")]
        public List<BarLinkInfo> BarLinks { get; set; }

        /// <summary>
        /// 配置模式
        /// </summary>
        [XmlElement("config_model")]
        public GroupConfigModelConfig ConfigModel { get; set; }

        /// <summary>
        /// 支付宝应用小程序APPID
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 小程序名称
        /// </summary>
        [XmlElement("mini_app_name")]
        public string MiniAppName { get; set; }

        /// <summary>
        /// 一般为集团名称拼音大写，英文，需要提前和支付宝酒店技术确认是否冲突
        /// </summary>
        [XmlElement("org_group_code")]
        public string OrgGroupCode { get; set; }

        /// <summary>
        /// 集团名称
        /// </summary>
        [XmlElement("org_group_name")]
        public string OrgGroupName { get; set; }
    }
}
