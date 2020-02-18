using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniMorphoApplistBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniMorphoApplistBatchqueryModel : AopObject
    {
        /// <summary>
        /// 批量查询时的，闪蝶应用ID数组
        /// </summary>
        [XmlArray("app_ids")]
        [XmlArrayItem("string")]
        public List<string> AppIds { get; set; }

        /// <summary>
        /// 闪蝶身份验证信息
        /// </summary>
        [XmlElement("identity")]
        public MorphoIdentity Identity { get; set; }

        /// <summary>
        /// 查询应用关键词
        /// </summary>
        [XmlElement("keyword")]
        public string Keyword { get; set; }

        /// <summary>
        /// 应用在线状态
        /// </summary>
        [XmlElement("online_state")]
        public long OnlineState { get; set; }

        /// <summary>
        /// 分页查询页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 应用状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 应用类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
