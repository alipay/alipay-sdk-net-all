using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SpuInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class SpuInfoVO : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("bind_attrs")]
        [XmlArrayItem("spu_attribute_info_v_o")]
        public List<SpuAttributeInfoVO> BindAttrs { get; set; }

        /// <summary>
        /// 标品所属类目ID
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("key_attrs")]
        [XmlArrayItem("spu_attribute_info_v_o")]
        public List<SpuAttributeInfoVO> KeyAttrs { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("pic_urls")]
        [XmlArrayItem("string")]
        public List<string> PicUrls { get; set; }

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
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
