using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcChargeBillQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcChargeBillQueryModel : AopObject
    {
        /// <summary>
        /// 蚂蚁门店id，用于水平权限鉴权。可通过ant.merchant.expand.shop.create创建蚂蚁门店获取
        /// </summary>
        [XmlElement("ant_shop_id")]
        public string AntShopId { get; set; }

        /// <summary>
        /// 企业码服务费单号
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 被抽佣的支付宝交易号
        /// </summary>
        [XmlElement("pay_no")]
        public string PayNo { get; set; }
    }
}
