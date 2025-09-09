using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineSmddCategoryBatchitemQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineSmddCategoryBatchitemQueryModel : AopObject
    {
        /// <summary>
        /// 买家唯一标识
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 类目ID列表
        /// </summary>
        [XmlArray("category_id_list")]
        [XmlArrayItem("string")]
        public List<string> CategoryIdList { get; set; }

        /// <summary>
        /// 桌码拓展对象
        /// </summary>
        [XmlElement("code_ext")]
        public CodeExtBean CodeExt { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
