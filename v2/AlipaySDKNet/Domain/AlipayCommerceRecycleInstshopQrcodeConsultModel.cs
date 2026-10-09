using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRecycleInstshopQrcodeConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRecycleInstshopQrcodeConsultModel : AopObject
    {
        /// <summary>
        /// 标准蚂蚁门店ID
        /// </summary>
        [XmlElement("alipay_shop_id")]
        public string AlipayShopId { get; set; }

        /// <summary>
        /// 支付宝回收分配给回收商家的线下即时到店模式的唯一身份编码.请联系对接人员获取
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }
    }
}
