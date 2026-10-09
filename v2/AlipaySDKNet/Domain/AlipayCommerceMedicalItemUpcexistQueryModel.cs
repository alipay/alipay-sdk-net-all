using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalItemUpcexistQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalItemUpcexistQueryModel : AopObject
    {
        /// <summary>
        /// item状态过滤条件（0上架，1下架 ，2冻结），为null时不按该字段过滤
        /// </summary>
        [XmlElement("item_status")]
        public long ItemStatus { get; set; }

        /// <summary>
        /// sku状态过滤条件（0上架，1售罄），为null时不按该字段过滤
        /// </summary>
        [XmlElement("sku_status")]
        public long SkuStatus { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("upc_list")]
        [XmlArrayItem("string")]
        public List<string> UpcList { get; set; }
    }
}
