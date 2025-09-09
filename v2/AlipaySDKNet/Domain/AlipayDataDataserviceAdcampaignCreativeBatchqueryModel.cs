using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdcampaignCreativeBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdcampaignCreativeBatchqueryModel : AopObject
    {
        /// <summary>
        /// 创意状态
        /// </summary>
        [XmlArray("creative_status_list")]
        [XmlArrayItem("string")]
        public List<string> CreativeStatusList { get; set; }

        /// <summary>
        /// 当前页 最小值1
        /// </summary>
        [XmlElement("current")]
        public long Current { get; set; }

        /// <summary>
        /// 一级营销目标code（如要查询当前场景下所有数据，入参为‘ALL’字段）
        /// </summary>
        [XmlElement("first_market_target_code")]
        public string FirstMarketTargetCode { get; set; }

        /// <summary>
        /// 单元id
        /// </summary>
        [XmlElement("group_id")]
        public long GroupId { get; set; }

        /// <summary>
        /// 二级营销目标code
        /// </summary>
        [XmlElement("market_target_code")]
        public string MarketTargetCode { get; set; }

        /// <summary>
        /// 每页数量[1,100]闭区间单页最大值限制
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 计划id
        /// </summary>
        [XmlElement("plan_id")]
        public long PlanId { get; set; }

        /// <summary>
        /// 商家tag
        /// </summary>
        [XmlElement("principal_tag")]
        public string PrincipalTag { get; set; }

        /// <summary>
        /// 场景code
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 搜索关键词(支持创意id/名称模糊搜索)
        /// </summary>
        [XmlElement("search_keywords")]
        public string SearchKeywords { get; set; }
    }
}
