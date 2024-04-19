using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundFlexiblestaffingInsuresignApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundFlexiblestaffingInsuresignApplyModel : AopObject
    {
        /// <summary>
        /// 场景码，固定值
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 证件号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 保险渠道固定值
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 产品码,固定值
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
