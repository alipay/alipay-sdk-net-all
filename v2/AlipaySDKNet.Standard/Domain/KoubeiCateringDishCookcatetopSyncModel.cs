using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiCateringDishCookcatetopSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringDishCookcatetopSyncModel : AopObject
    {
        /// <summary>
        /// 菜谱类目置顶操作列表，一次批量操作最多100个
        /// </summary>
        [XmlArray("kbdish_cook_cate_top_info_list")]
        [XmlArrayItem("kbdish_cook_cate_top_info")]
        public List<KbdishCookCateTopInfo> KbdishCookCateTopInfoList { get; set; }
    }
}
