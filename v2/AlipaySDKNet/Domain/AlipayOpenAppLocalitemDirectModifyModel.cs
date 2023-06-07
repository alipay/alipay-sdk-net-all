using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppLocalitemDirectModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppLocalitemDirectModifyModel : AopObject
    {
        /// <summary>
        /// 商品属性列表，具体的属性值可以参考本地生活商品模板文档：https://opendocs.alipay.com/pre-open/07pywg?pathHash=1c499cb5
        /// </summary>
        [XmlArray("attrs")]
        [XmlArrayItem("app_item_attr_v_o")]
        public List<AppItemAttrVO> Attrs { get; set; }

        /// <summary>
        /// 支付宝平台侧商品ID，是支付宝平台侧商品的唯一标识，后续与平台交互，需要使用该 ID，建议持久化。该字段特殊可选，与out_item_id不能同时为空，优先使用item_id。
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商家侧商品ID，要求 APPID 下全局唯一。该字段特殊可选，与item_id不能同时为空，优先使用item_id。
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }

        /// <summary>
        /// sku数组
        /// </summary>
        [XmlArray("skus")]
        [XmlArrayItem("local_item_direct_modify_sku")]
        public List<LocalItemDirectModifySku> Skus { get; set; }

        /// <summary>
        /// start_time描述售卖开始时间，end_time描述售卖结束时间，时间格式均为yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("sold_time")]
        public TimeRangeStructVO SoldTime { get; set; }
    }
}
