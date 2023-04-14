using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiCateringOrderPayResponse.
    /// </summary>
    public class KoubeiCateringOrderPayResponse : AopResponse
    {
        /// <summary>
        /// online_pay：表示在线买单跳转地址
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 该支付宝门店对应商家的partnerId号
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 支付宝门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 当前用户操作的桌码
        /// </summary>
        [XmlElement("table_num")]
        public string TableNum { get; set; }

        /// <summary>
        /// 当前操作用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
