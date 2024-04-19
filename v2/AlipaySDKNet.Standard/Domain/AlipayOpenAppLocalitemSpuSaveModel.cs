using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppLocalitemSpuSaveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppLocalitemSpuSaveModel : AopObject
    {
        /// <summary>
        /// 属性KV列表，通过alipay.open.app.localitem.template.query获取本地商品模板信息接口得到商品属性key，is_required=1时属性必填
        /// </summary>
        [XmlArray("attrs")]
        [XmlArrayItem("app_item_attr_v_o")]
        public List<AppItemAttrVO> Attrs { get; set; }

        /// <summary>
        /// 商品类目ID，可通过alipay.open.app.localitem.allcategory.query接口获取
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 商品类型
        /// </summary>
        [XmlElement("item_type")]
        public string ItemType { get; set; }

        /// <summary>
        /// 外部标品id，要求 APPID 下全局唯一
        /// </summary>
        [XmlElement("out_spu_id")]
        public string OutSpuId { get; set; }

        /// <summary>
        /// 标品id
        /// </summary>
        [XmlElement("spu_id")]
        public string SpuId { get; set; }

        /// <summary>
        /// 标品名称
        /// </summary>
        [XmlElement("spu_name")]
        public string SpuName { get; set; }

        /// <summary>
        /// 标品状态
        /// </summary>
        [XmlElement("spu_status")]
        public string SpuStatus { get; set; }
    }
}
