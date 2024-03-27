using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdReportdataQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdReportdataQueryModel : AopObject
    {
        /// <summary>
        /// 数据维度： ORDER-订单； PLAN-计划； GROUP-单元； CREATIVE-创意； MARKET_TARGET-营销目标； PRINCIPAL-商家; 【不同数据维度决定了出参data_id代表的数据类型不一样分别为plan_id,group_id,order_id,creative_id，营销目标和商家维度时data_id为空且不返回conversion_data_list数据】
        /// </summary>
        [XmlElement("ad_level")]
        public string AdLevel { get; set; }

        /// <summary>
        /// 登录用户支付宝统一ID,2088开头字符串。登录校验和可反查出user_id。 【alipay_pid和principal_tag使用方法：若为代理商会获取代理商下指定委托人数据。若是直客会获取自身的合计数据。】
        /// </summary>
        [XmlElement("alipay_pid")]
        public string AlipayPid { get; set; }

        /// <summary>
        /// 权限token,唯一值,在广告投放平台商家详情获取。
        /// </summary>
        [XmlElement("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 广告投放平台生成的创意ID，此为数据筛选条件不影响数据汇总纬度。
        /// </summary>
        [XmlArray("creative_id_list")]
        [XmlArrayItem("string")]
        public List<string> CreativeIdList { get; set; }

        /// <summary>
        /// 分页查询的页码从1开始
        /// </summary>
        [XmlElement("current")]
        public long Current { get; set; }

        /// <summary>
        /// 投放模式（订单/计划/单元/创意id_list都为空时此参数有效）： STANDARD_TOUFANG-标准三段式； TRUST_TOUFANG-托管式；
        /// </summary>
        [XmlElement("delivery_mode")]
        public string DeliveryMode { get; set; }

        /// <summary>
        /// 数据查询结束时间，查询时间不能大于最近7天，时间格式：yyyyMMdd【最大时间-最小时间<=7时间左闭右闭】
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 广告投放平台生成的单元ID，此为数据筛选条件不影响数据汇总纬度。
        /// </summary>
        [XmlArray("group_id_list")]
        [XmlArrayItem("string")]
        public List<string> GroupIdList { get; set; }

        /// <summary>
        /// 广告投放平台生成的订单ID，此为数据筛选条件不影响数据汇总纬度。
        /// </summary>
        [XmlArray("order_id_list")]
        [XmlArrayItem("string")]
        public List<string> OrderIdList { get; set; }

        /// <summary>
        /// 分页查询时每页返回条数最大1万，按明细汇总时按日期倒序
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 广告投放平台生成的计划ID，此为数据筛选条件不影响数据汇总纬度。
        /// </summary>
        [XmlArray("plan_id_list")]
        [XmlArrayItem("string")]
        public List<string> PlanIdList { get; set; }

        /// <summary>
        /// 商家标志,唯一值,在广告投放平台商家详情获取。
        /// </summary>
        [XmlElement("principal_tag")]
        public string PrincipalTag { get; set; }

        /// <summary>
        /// 数据汇总方式。SUM-汇总；DETAIL-明细分天； 【SUM时：根据ad_level汇总为单条数据。 DETAIL时：汇总成分天x ad_level的多条数据】
        /// </summary>
        [XmlElement("query_type")]
        public string QueryType { get; set; }

        /// <summary>
        /// 投放方式：SceneType： INTELLIGENT-全域智投 SEARCH-搜索 APP-端内展示 BRAND-品牌投放
        /// </summary>
        [XmlElement("scene_type")]
        public string SceneType { get; set; }

        /// <summary>
        /// 数据查询开始时间，查询时间不能大于最近7天，时间格式：yyyyMMdd
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }
    }
}
