using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiRetailWmsGoodssafetyinventoryModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailWmsGoodssafetyinventoryModifyModel : AopObject
    {
        /// <summary>
        /// 货品安全库存
        /// </summary>
        [XmlArray("goods_safety_inventorys")]
        [XmlArrayItem("goods_safety_inventory")]
        public List<GoodsSafetyInventory> GoodsSafetyInventorys { get; set; }
    }
}
