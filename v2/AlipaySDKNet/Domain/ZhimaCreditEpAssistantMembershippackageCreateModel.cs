using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpAssistantMembershippackageCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpAssistantMembershippackageCreateModel : AopObject
    {
        /// <summary>
        /// 唯一键，幂等控制，同一个id不允许多次购买
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 企信会员产品码，由企信分配
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 企信会员产品包，由企信分配
        /// </summary>
        [XmlElement("product_sku")]
        public string ProductSku { get; set; }
    }
}
