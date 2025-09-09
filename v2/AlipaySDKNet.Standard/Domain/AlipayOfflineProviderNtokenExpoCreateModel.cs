using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderNtokenExpoCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderNtokenExpoCreateModel : AopObject
    {
        /// <summary>
        /// 主活动头图
        /// </summary>
        [XmlElement("head_img")]
        public string HeadImg { get; set; }

        /// <summary>
        /// 活动Icon
        /// </summary>
        [XmlElement("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 子活动ID
        /// </summary>
        [XmlElement("meeting_timeuuid")]
        public string MeetingTimeuuid { get; set; }

        /// <summary>
        /// 收藏包副标题
        /// </summary>
        [XmlElement("package_subtitle")]
        public string PackageSubtitle { get; set; }

        /// <summary>
        /// 收藏包标题
        /// </summary>
        [XmlElement("package_title")]
        public string PackageTitle { get; set; }

        /// <summary>
        /// 展示模式
        /// </summary>
        [XmlElement("show_mode")]
        public string ShowMode { get; set; }

        /// <summary>
        /// 收藏链接列表
        /// </summary>
        [XmlArray("url_info_list")]
        [XmlArrayItem("url_info_list")]
        public List<UrlInfoList> UrlInfoList { get; set; }
    }
}
