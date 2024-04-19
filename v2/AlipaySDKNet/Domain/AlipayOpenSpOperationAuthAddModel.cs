using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpOperationAuthAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpOperationAuthAddModel : AopObject
    {
        /// <summary>
        /// 授权产品码，零售通填写KX_ECOLOGY_SOLUTION
        /// </summary>
        [XmlElement("auth_product_code")]
        public string AuthProductCode { get; set; }

        /// <summary>
        /// 直连商户PID
        /// </summary>
        [XmlElement("merchant_no")]
        public string MerchantNo { get; set; }

        /// <summary>
        /// 外部操作流水，ISV自定义。每次操作需要确保唯一。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
