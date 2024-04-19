using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemDeliveryInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class ItemDeliveryInfoVO : AopObject
    {
        /// <summary>
        /// 履约配置信息，通过alipay.open.app.delivery.template.query获取属性key列表，is_required=true时属性必填
        /// </summary>
        [XmlArray("attrs")]
        [XmlArrayItem("app_item_attr_v_o")]
        public List<AppItemAttrVO> Attrs { get; set; }

        /// <summary>
        /// 履约信息主键ID，建议调用方持久化方便后续查询编辑使用
        /// </summary>
        [XmlElement("delivery_id")]
        public string DeliveryId { get; set; }

        /// <summary>
        /// 履约名称
        /// </summary>
        [XmlElement("delivery_name")]
        public string DeliveryName { get; set; }

        /// <summary>
        /// 履约类型
        /// </summary>
        [XmlElement("delivery_type")]
        public string DeliveryType { get; set; }
    }
}
