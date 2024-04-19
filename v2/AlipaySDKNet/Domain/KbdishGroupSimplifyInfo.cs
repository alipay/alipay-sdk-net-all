using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KbdishGroupSimplifyInfo Data Structure.
    /// </summary>
    [Serializable]
    public class KbdishGroupSimplifyInfo : AopObject
    {
        /// <summary>
        /// 套餐组上的活动信息，属isv外部活动信息
        /// </summary>
        [XmlElement("activity_info")]
        public string ActivityInfo { get; set; }

        /// <summary>
        /// 套餐组明细
        /// </summary>
        [XmlArray("group_detail_list")]
        [XmlArrayItem("kbdish_group_detail_simplify_info")]
        public List<KbdishGroupDetailSimplifyInfo> GroupDetailList { get; set; }

        /// <summary>
        /// 套餐组规则，fix：是否固定套餐，true：是；false：不是。max_count：最大可选数量；min_count：最小可选数量。sort：套餐组排序值数字从小到大排
        /// </summary>
        [XmlElement("group_rule")]
        public string GroupRule { get; set; }

        /// <summary>
        /// 套餐组名称，固定组可不传
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
