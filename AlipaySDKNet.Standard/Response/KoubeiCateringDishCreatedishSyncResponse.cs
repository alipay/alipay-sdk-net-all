using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiCateringDishCreatedishSyncResponse.
    /// </summary>
    public class KoubeiCateringDishCreatedishSyncResponse : AopResponse
    {
        /// <summary>
        /// 口碑菜品id
        /// </summary>
        [XmlElement("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// 反查失败的菜品信息
        /// </summary>
        [XmlArray("fail_group_detail_list")]
        [XmlArrayItem("kbdish_detail_info")]
        public List<KbdishDetailInfo> FailGroupDetailList { get; set; }

        /// <summary>
        /// 是否需要重试
        /// </summary>
        [XmlElement("retry")]
        public bool Retry { get; set; }

        /// <summary>
        /// 口碑菜品库skuId列表
        /// </summary>
        [XmlArray("sku_id_list")]
        [XmlArrayItem("string")]
        public List<string> SkuIdList { get; set; }
    }
}
