using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpNordermaterialsapplyShopQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpNordermaterialsapplyShopQueryModel : AopObject
    {
        /// <summary>
        /// 创建物料申请接口时，返回的ID
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }

        /// <summary>
        /// 门店单标识
        /// </summary>
        [XmlElement("shop_order_no")]
        public string ShopOrderNo { get; set; }
    }
}
