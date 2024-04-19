using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataAntsycmShopdataBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataAntsycmShopdataBatchqueryModel : AopObject
    {
        /// <summary>
        /// 商户授权码
        /// </summary>
        [XmlElement("business_code")]
        public string BusinessCode { get; set; }

        /// <summary>
        /// 分页页数
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 门店得分筛选范围
        /// </summary>
        [XmlElement("score_range")]
        public ScoreRangeInfoDTO ScoreRange { get; set; }

        /// <summary>
        /// 获取分数类型
        /// </summary>
        [XmlArray("score_type")]
        [XmlArrayItem("string")]
        public List<string> ScoreType { get; set; }

        /// <summary>
        /// 见<a href = "https://opendocs.alipay.com/pre-open/0bue7u">省市区维表</a>
        /// </summary>
        [XmlArray("shop_area")]
        [XmlArrayItem("shop_area_info_d_t_o")]
        public List<ShopAreaInfoDTO> ShopArea { get; set; }

        /// <summary>
        /// 排序名
        /// </summary>
        [XmlElement("sort_name")]
        public string SortName { get; set; }

        /// <summary>
        /// 任务ID
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }

        /// <summary>
        /// 查询TOP门店数量，如：top10
        /// </summary>
        [XmlElement("top_num")]
        public long TopNum { get; set; }
    }
}
