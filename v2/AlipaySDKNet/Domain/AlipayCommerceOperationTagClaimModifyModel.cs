using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationTagClaimModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationTagClaimModifyModel : AopObject
    {
        /// <summary>
        /// 商户新支付宝账号，一般是手机号或邮箱
        /// </summary>
        [XmlElement("new_alipay_account")]
        public string NewAlipayAccount { get; set; }

        /// <summary>
        /// 商户原支付宝账号，一般是手机号或邮箱
        /// </summary>
        [XmlElement("old_alipay_account")]
        public string OldAlipayAccount { get; set; }

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
