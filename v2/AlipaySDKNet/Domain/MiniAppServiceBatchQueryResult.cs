using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MiniAppServiceBatchQueryResult Data Structure.
    /// </summary>
    [Serializable]
    public class MiniAppServiceBatchQueryResult : AopObject
    {
        /// <summary>
        /// 会员频道历史累计销量,若>10000以万为单位
        /// </summary>
        [XmlElement("aggre_sales")]
        public string AggreSales { get; set; }

        /// <summary>
        /// true：可用，false：不可用
        /// </summary>
        [XmlElement("available")]
        public bool Available { get; set; }

        /// <summary>
        /// 商品详情页跳转URL
        /// </summary>
        [XmlElement("detail_url")]
        public string DetailUrl { get; set; }

        /// <summary>
        /// 行家说名称（图鲲）
        /// </summary>
        [XmlElement("expert_remark")]
        public string ExpertRemark { get; set; }

        /// <summary>
        /// 行家说头像（图鲲）
        /// </summary>
        [XmlElement("expert_remark_icon")]
        public string ExpertRemarkIcon { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("featured_labels")]
        [XmlArrayItem("string")]
        public List<string> FeaturedLabels { get; set; }

        /// <summary>
        /// 用于调用方关联商品ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("marketing_labels")]
        [XmlArrayItem("string")]
        public List<string> MarketingLabels { get; set; }

        /// <summary>
        /// 积分
        /// </summary>
        [XmlElement("point")]
        public string Point { get; set; }

        /// <summary>
        /// 单位为元，货币单位为CNY
        /// </summary>
        [XmlElement("point_preferential_yuan")]
        public string PointPreferentialYuan { get; set; }

        /// <summary>
        /// 排行榜跳转链接URL
        /// </summary>
        [XmlElement("rank_link")]
        public string RankLink { get; set; }

        /// <summary>
        /// 所在排行榜供给排名
        /// </summary>
        [XmlElement("rank_pos")]
        public string RankPos { get; set; }

        /// <summary>
        /// 不可用原因
        /// </summary>
        [XmlElement("reason_desc")]
        public string ReasonDesc { get; set; }

        /// <summary>
        /// 会员服务ID
        /// </summary>
        [XmlElement("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// 所在榜单二级类目名称
        /// </summary>
        [XmlElement("sub_cat_name")]
        public string SubCatName { get; set; }

        /// <summary>
        /// 单位为元，货币单位为CNY
        /// </summary>
        [XmlElement("yuan")]
        public string Yuan { get; set; }
    }
}
