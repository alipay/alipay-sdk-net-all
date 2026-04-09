using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDigitalmgmtDcmealMightydishcategoryInfoSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDigitalmgmtDcmealMightydishcategoryInfoSyncModel : AopObject
    {
        /// <summary>
        /// 菜品分类数组
        /// </summary>
        [XmlArray("dish_category_list")]
        [XmlArrayItem("dcmeal_dish_category_detail")]
        public List<DcmealDishCategoryDetail> DishCategoryList { get; set; }
    }
}
