using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiCateringDishMenuQueryResponse.
    /// </summary>
    public class KoubeiCateringDishMenuQueryResponse : AopResponse
    {
        /// <summary>
        /// 菜谱背景图片id
        /// </summary>
        [XmlElement("bg_image")]
        public string BgImage { get; set; }

        /// <summary>
        /// 菜谱类目列表
        /// </summary>
        [XmlElement("category_list")]
        public KbdishCategorySimplifyInfo CategoryList { get; set; }

        /// <summary>
        /// 菜谱名称
        /// </summary>
        [XmlElement("cook_name")]
        public string CookName { get; set; }

        /// <summary>
        /// 时间区间日期结束
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 时间区间截止 闭区间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 外部门店id列表
        /// </summary>
        [XmlArray("out_shop_id")]
        [XmlArrayItem("string")]
        public List<string> OutShopId { get; set; }

        /// <summary>
        /// 时间约束类型 forever:永久; week:按周，每周周几 month:按月,每月几号
        /// </summary>
        [XmlElement("period_type")]
        public string PeriodType { get; set; }

        /// <summary>
        /// 时间控制值,如果选的week, 值 1,2,3,4 ; 如果选择month，值 1,11; 如果选择永久，为空
        /// </summary>
        [XmlElement("period_value")]
        public string PeriodValue { get; set; }

        /// <summary>
        /// 控制的日期区间开始
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 时间控制 到分 闭区间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 菜谱状态，open：启用，stop：停用
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
