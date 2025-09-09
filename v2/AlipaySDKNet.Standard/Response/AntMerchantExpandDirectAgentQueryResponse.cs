using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandDirectAgentQueryResponse.
    /// </summary>
    public class AntMerchantExpandDirectAgentQueryResponse : AopResponse
    {
        /// <summary>
        /// 蚂蚁门店shop_id为空的原因
        /// </summary>
        [XmlElement("none_shop_reason")]
        public string NoneShopReason { get; set; }

        /// <summary>
        /// 商户支付宝账号对应的商户pid
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 支付宝风控审核不通过原因
        /// </summary>
        [XmlElement("reject_reason")]
        public string RejectReason { get; set; }

        /// <summary>
        /// status=SUCCESS时，支付宝内部创建成功的蚂蚁门店ID。如果蚂蚁门店ID返回为空则代表未创建成功，需自行参考<a href="https://opendocs.alipay.com/open/014vrh?pathHash=37da4e7d">蚂蚁门店管理</a>创建门店。
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 商户进件状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
