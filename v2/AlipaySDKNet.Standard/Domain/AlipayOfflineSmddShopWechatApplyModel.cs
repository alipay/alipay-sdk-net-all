using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineSmddShopWechatApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineSmddShopWechatApplyModel : AopObject
    {
        /// <summary>
        /// 商户id
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 操作类型，OPEN：开通，CLOSE：关闭
        /// </summary>
        [XmlElement("operation_type")]
        public string OperationType { get; set; }
    }
}
