using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SkuStateDetail Data Structure.
    /// </summary>
    [Serializable]
    public class SkuStateDetail : AopObject
    {
        /// <summary>
        /// 库存（如果不可售传入值0。单位：件）
        /// </summary>
        [XmlElement("account")]
        public long Account { get; set; }

        /// <summary>
        /// 加料列表
        /// </summary>
        [XmlArray("attach_list")]
        [XmlArrayItem("attach_good")]
        public List<AttachGood> AttachList { get; set; }

        /// <summary>
        /// 可以多选
        /// </summary>
        [XmlElement("attach_multiple")]
        public bool AttachMultiple { get; set; }

        /// <summary>
        /// 规格标签
        /// </summary>
        [XmlArray("attributes")]
        [XmlArrayItem("a_i_chat_attribute")]
        public List<AIChatAttribute> Attributes { get; set; }

        /// <summary>
        /// itemid
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 果茶
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 16元
        /// </summary>
        [XmlElement("price")]
        public long Price { get; set; }

        /// <summary>
        /// 推荐
        /// </summary>
        [XmlElement("recommend")]
        public bool Recommend { get; set; }

        /// <summary>
        /// 口味做法
        /// </summary>
        [XmlArray("taste_methods")]
        [XmlArrayItem("taste_method")]
        public List<TasteMethod> TasteMethods { get; set; }
    }
}
