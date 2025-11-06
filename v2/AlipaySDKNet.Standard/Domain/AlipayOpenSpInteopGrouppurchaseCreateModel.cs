using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpInteopGrouppurchaseCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpInteopGrouppurchaseCreateModel : AopObject
    {
        /// <summary>
        /// 商家联系方式
        /// </summary>
        [XmlElement("contact_info")]
        public GroupPurchaseContactInfo ContactInfo { get; set; }

        /// <summary>
        /// 一体化作业开通主单号，单号为服务商一体化作业主单创建返回值。
        /// </summary>
        [XmlElement("inteop_order_no")]
        public string InteopOrderNo { get; set; }

        /// <summary>
        /// 解决方案店铺信息
        /// </summary>
        [XmlElement("inteop_shop_info")]
        public GroupPurchaseShopInfo InteopShopInfo { get; set; }
    }
}
