using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceAcommunicationDiscountitemTagModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceAcommunicationDiscountitemTagModifyModel : AopObject
    {
        /// <summary>
        /// 机构侧商品ID
        /// </summary>
        [XmlElement("isv_item_id")]
        public string IsvItemId { get; set; }

        /// <summary>
        /// 商品分层标签列表
        /// </summary>
        [XmlElement("tag_code_list")]
        public string TagCodeList { get; set; }
    }
}
