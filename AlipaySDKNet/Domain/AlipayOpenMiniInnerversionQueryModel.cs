using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerversionQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerversionQueryModel : AopObject
    {
        /// <summary>
        /// 淘宝
        /// </summary>
        [XmlElement("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 多个端集合
        /// </summary>
        [XmlArray("bundle_ids")]
        [XmlArrayItem("string")]
        public List<string> BundleIds { get; set; }

        /// <summary>
        /// 排序字段
        /// </summary>
        [XmlElement("first_sort_col")]
        public string FirstSortCol { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        [XmlElement("first_sort_col_order")]
        public string FirstSortColOrder { get; set; }

        /// <summary>
        /// 组合状态
        /// </summary>
        [XmlArray("group_status_list")]
        [XmlArrayItem("string")]
        public List<string> GroupStatusList { get; set; }

        /// <summary>
        /// 租户类型
        /// </summary>
        [XmlElement("inst_code")]
        public string InstCode { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 页数-从0开始
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页大小，最大20
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 版本列表
        /// </summary>
        [XmlArray("version_list")]
        [XmlArrayItem("string")]
        public List<string> VersionList { get; set; }
    }
}
