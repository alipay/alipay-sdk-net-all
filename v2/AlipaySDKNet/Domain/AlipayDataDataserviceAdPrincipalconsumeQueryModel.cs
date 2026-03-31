using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdPrincipalconsumeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdPrincipalconsumeQueryModel : AopObject
    {
        /// <summary>
        /// 场景编码目前固定： SEARCH-搜索
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 分页查询的页码从1开始
        /// </summary>
        [XmlElement("current")]
        public long Current { get; set; }

        /// <summary>
        /// 数据查询结束时间，时间格式：yyyy-MM-dd，结束时间不能大于当天
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 聚合条件数据维度： DATE-天； MONTH-月
        /// </summary>
        [XmlElement("group_condition")]
        public string GroupCondition { get; set; }

        /// <summary>
        /// 每页条数，最大100，明细按日期倒序，为空时默认=100，单位：条
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 商家标志,唯一值,在广告投放平台商家详情获取。
        /// </summary>
        [XmlElement("principal_tag")]
        public string PrincipalTag { get; set; }

        /// <summary>
        /// 全域智投-INTELLIGENT 搜索推广-SEARCH 品牌整合营销-BRAND 展示推广-APP 户外推广-OOH
        /// </summary>
        [XmlElement("scene_type")]
        public string SceneType { get; set; }

        /// <summary>
        /// 消耗类型数据维度： "RTB"-竞价交易 "GD"-合约交易
        /// </summary>
        [XmlElement("sell_mode")]
        public string SellMode { get; set; }

        /// <summary>
        /// 数据查询开始时间，时间格式：yyyy-MM-dd，开始时间不能大于结束时间
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }
    }
}
