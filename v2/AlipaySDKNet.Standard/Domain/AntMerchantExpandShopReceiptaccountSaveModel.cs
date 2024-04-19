using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandShopReceiptaccountSaveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandShopReceiptaccountSaveModel : AopObject
    {
        /// <summary>
        /// 是否承诺收单账号信息准确。具体承诺信息可查看 <a href="https://gw.alipayobjects.com/os/bmw-prod/922bafa8-a712-4f79-aa32-6f08d7359a5c.docx">门店信息承诺函</a>。 Y 是 N 否
        /// </summary>
        [XmlElement("promise")]
        public string Promise { get; set; }

        /// <summary>
        /// 收单账号
        /// </summary>
        [XmlElement("receipt_account_id")]
        public string ReceiptAccountId { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
