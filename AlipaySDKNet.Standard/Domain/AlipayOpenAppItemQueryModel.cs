using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppItemQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppItemQueryModel : AopObject
    {
        /// <summary>
        /// 支付平台侧商品id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 是否查询编辑版本，0查询在线版本，1查询编辑版本。默认为0
        /// </summary>
        [XmlElement("need_edit_spu")]
        public long NeedEditSpu { get; set; }

        /// <summary>
        /// 商家侧商品id
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }
    }
}
