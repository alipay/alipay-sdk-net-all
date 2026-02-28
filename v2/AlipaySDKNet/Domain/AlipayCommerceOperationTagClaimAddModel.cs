using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationTagClaimAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationTagClaimAddModel : AopObject
    {
        /// <summary>
        /// 商户支付宝账号，一般是手机号或邮箱
        /// </summary>
        [XmlElement("alipay_account")]
        public string AlipayAccount { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("qrcode_list")]
        [XmlArrayItem("string")]
        public List<string> QrcodeList { get; set; }

        /// <summary>
        /// 商户在支付宝认证的门店ID
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 商户在支付宝认证的门店ID的类型
        /// </summary>
        [XmlElement("store_id_type")]
        public string StoreIdType { get; set; }
    }
}
