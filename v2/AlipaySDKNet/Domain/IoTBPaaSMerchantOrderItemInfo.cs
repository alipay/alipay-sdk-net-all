using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IoTBPaaSMerchantOrderItemInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IoTBPaaSMerchantOrderItemInfo : AopObject
    {
        /// <summary>
        /// 商品属性列表
        /// </summary>
        [XmlArray("attrs")]
        [XmlArrayItem("io_t_b_paa_s_key_value")]
        public List<IoTBPaaSKeyValue> Attrs { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [XmlElement("item_num")]
        public string ItemNum { get; set; }

        /// <summary>
        /// 商品价格
        /// </summary>
        [XmlElement("item_price")]
        public string ItemPrice { get; set; }

        /// <summary>
        /// 商品规格列表
        /// </summary>
        [XmlArray("specs")]
        [XmlArrayItem("io_t_b_paa_s_key_value")]
        public List<IoTBPaaSKeyValue> Specs { get; set; }
    }
}
