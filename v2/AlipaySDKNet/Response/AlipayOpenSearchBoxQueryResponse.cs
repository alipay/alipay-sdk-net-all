using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSearchBoxQueryResponse.
    /// </summary>
    public class AlipayOpenSearchBoxQueryResponse : AopResponse
    {
        /// <summary>
        /// 搜索直达账号模块
        /// </summary>
        [XmlElement("account_module")]
        public SearchBoxAccountModule AccountModule { get; set; }

        /// <summary>
        /// 地域触发词
        /// </summary>
        [XmlElement("area_keyword_module")]
        public SearchBoxAreaKeyWordModule AreaKeywordModule { get; set; }

        /// <summary>
        /// 搜索直达基础信息模块
        /// </summary>
        [XmlElement("basic_info_module")]
        public SearchBoxBasicInfoModule BasicInfoModule { get; set; }

        /// <summary>
        /// 搜索直达配置id
        /// </summary>
        [XmlElement("box_id")]
        public string BoxId { get; set; }

        /// <summary>
        /// 搜索直达配置状态，AUDIT-审核中/ONLINE-已上架/REJECT-驳回/OFFLINE-已下架
        /// </summary>
        [XmlElement("box_status")]
        public string BoxStatus { get; set; }

        /// <summary>
        /// 商圈信息
        /// </summary>
        [XmlElement("business_district_module")]
        public BoxBusinessDistrictModule BusinessDistrictModule { get; set; }

        /// <summary>
        /// 搜索直达默认触发词，由系统生成，无法修改
        /// </summary>
        [XmlArray("default_keywords")]
        [XmlArrayItem("string")]
        public List<string> DefaultKeywords { get; set; }

        /// <summary>
        /// 搜索直达关键词模块
        /// </summary>
        [XmlElement("keyword_module")]
        public SearchBoxKeyWordModule KeywordModule { get; set; }

        /// <summary>
        /// 最近一次审核氛围图
        /// </summary>
        [XmlElement("latest_audit_image")]
        public SearchBoxImageModule LatestAuditImage { get; set; }

        /// <summary>
        /// 搜索直达服务模块
        /// </summary>
        [XmlElement("service_module")]
        public SearchBoxServiceModule ServiceModule { get; set; }

        /// <summary>
        /// 已生效氛围图
        /// </summary>
        [XmlElement("valid_image")]
        public SearchBoxImageModule ValidImage { get; set; }
    }
}
