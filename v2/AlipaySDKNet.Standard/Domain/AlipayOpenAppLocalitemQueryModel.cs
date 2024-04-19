using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppLocalitemQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppLocalitemQueryModel : AopObject
    {
        /// <summary>
        /// 支付平台侧商品id。与商家侧商品id不能同时为空，如果都提供，优先使用商家侧商品id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 是否查询编辑版本。默认为0
        /// </summary>
        [XmlElement("need_edit_spu")]
        public string NeedEditSpu { get; set; }

        /// <summary>
        /// 商家侧商品id。与支付平台侧商品id不能同时为空，如果都提供，优先使用商家侧商品id。
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }
    }
}
