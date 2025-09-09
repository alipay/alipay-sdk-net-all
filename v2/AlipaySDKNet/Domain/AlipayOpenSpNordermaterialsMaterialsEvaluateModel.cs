using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpNordermaterialsMaterialsEvaluateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpNordermaterialsMaterialsEvaluateModel : AopObject
    {
        /// <summary>
        /// 生产单号，用于匹配物料信息校验
        /// </summary>
        [XmlElement("production_order_no")]
        public string ProductionOrderNo { get; set; }

        /// <summary>
        /// 需要回传校验的门店物料信息
        /// </summary>
        [XmlArray("shop_materials_valid_info")]
        [XmlArrayItem("shop_materials_valid_info")]
        public List<ShopMaterialsValidInfo> ShopMaterialsValidInfo { get; set; }
    }
}
