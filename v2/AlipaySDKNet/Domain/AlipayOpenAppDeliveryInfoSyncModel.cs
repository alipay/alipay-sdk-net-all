using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppDeliveryInfoSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppDeliveryInfoSyncModel : AopObject
    {
        /// <summary>
        /// 履约属性，从模板中查询(alipay.open.app.delivery.template.query)得到，is_required=1时表示属性必填。
        /// </summary>
        [XmlArray("attrs")]
        [XmlArrayItem("app_item_attr_v_o")]
        public List<AppItemAttrVO> Attrs { get; set; }

        /// <summary>
        /// 履约信息主键可唯一确定一条履约，该字段用来区分创建or更新履约信息。
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
