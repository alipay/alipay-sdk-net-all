using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcCreditIsvcapitalUnfreezeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcCreditIsvcapitalUnfreezeModel : AopObject
    {
        /// <summary>
        /// 企业码内部自动生成企业唯一标识
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 商户冻结单号，银行幂等字段
        /// </summary>
        [XmlElement("out_freeze_no")]
        public string OutFreezeNo { get; set; }
    }
}
