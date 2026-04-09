using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDigitalmgmtDcmealMightydisharrangeInfoSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDigitalmgmtDcmealMightydisharrangeInfoSyncModel : AopObject
    {
        /// <summary>
        /// 排菜数据数组
        /// </summary>
        [XmlArray("dish_arrange_list")]
        [XmlArrayItem("dcmeal_dish_arrange_detail")]
        public List<DcmealDishArrangeDetail> DishArrangeList { get; set; }
    }
}
