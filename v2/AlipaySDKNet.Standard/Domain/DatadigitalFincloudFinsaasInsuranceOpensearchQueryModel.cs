using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalFincloudFinsaasInsuranceOpensearchQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalFincloudFinsaasInsuranceOpensearchQueryModel : AopObject
    {
        /// <summary>
        /// 搜索的领域值，默认为all 全网搜索
        /// </summary>
        [XmlElement("domain")]
        public string Domain { get; set; }

        /// <summary>
        /// 多站点"｜"分割，最大支持个数为3
        /// </summary>
        [XmlElement("include_sites")]
        public string IncludeSites { get; set; }

        /// <summary>
        /// 不传默认10
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 要搜索的问题
        /// </summary>
        [XmlElement("query")]
        public string Query { get; set; }

        /// <summary>
        /// 搜索使用方来源
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 是否开启调试模式
        /// </summary>
        [XmlElement("search_mode")]
        public string SearchMode { get; set; }
    }
}
