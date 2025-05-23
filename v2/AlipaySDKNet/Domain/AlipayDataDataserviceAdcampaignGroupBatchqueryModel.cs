using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdcampaignGroupBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdcampaignGroupBatchqueryModel : AopObject
    {
        /// <summary>
        /// 出价方式类型
        /// </summary>
        [XmlElement("bid_type")]
        public string BidType { get; set; }

        /// <summary>
        /// 当前页（最小为1）
        /// </summary>
        [XmlElement("current")]
        public long Current { get; set; }

        /// <summary>
        /// 一级营销目标code（如要查询当前场景下所有数据，入参为‘ALL’字段）
        /// </summary>
        [XmlElement("first_market_target_code")]
        public string FirstMarketTargetCode { get; set; }

        /// <summary>
        /// 单元状态
        /// </summary>
        [XmlArray("group_status_list")]
        [XmlArrayItem("string")]
        public List<string> GroupStatusList { get; set; }

        /// <summary>
        /// 二级营销目标code。 注意事项：层级关系和投放平台层级关系保持一致。 1.销售线索收集（一级）:tag000001，销售线索收集（二级）tag200600 2.自定义投放（一级）tag000004，自定义投放（二级）tag902001
        /// </summary>
        [XmlElement("market_target_code")]
        public string MarketTargetCode { get; set; }

        /// <summary>
        /// 每页数量[1,100]闭区间
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 计划id
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// 商家tag
        /// </summary>
        [XmlElement("principal_tag")]
        public string PrincipalTag { get; set; }

        /// <summary>
        /// 场景
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 搜索关键词(列表-支持单元id/名称模糊搜索)
        /// </summary>
        [XmlElement("search_keywords")]
        public string SearchKeywords { get; set; }
    }
}
