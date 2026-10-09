using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpNordermaterialsapplyMaterialsCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpNordermaterialsapplyMaterialsCreateModel : AopObject
    {
        /// <summary>
        /// 申请单ID
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }

        /// <summary>
        /// 该门店下的物料信息
        /// </summary>
        [XmlArray("materials_info")]
        [XmlArrayItem("create_materials_info")]
        public List<CreateMaterialsInfo> MaterialsInfo { get; set; }

        /// <summary>
        /// 门店单标识
        /// </summary>
        [XmlElement("shop_order_no")]
        public string ShopOrderNo { get; set; }
    }
}
