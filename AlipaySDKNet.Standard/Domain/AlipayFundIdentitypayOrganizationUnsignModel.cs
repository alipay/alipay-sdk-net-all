using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundIdentitypayOrganizationUnsignModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundIdentitypayOrganizationUnsignModel : AopObject
    {
        /// <summary>
        /// 解约场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 外部组织id(全局唯一)
        /// </summary>
        [XmlElement("out_org_id")]
        public string OutOrgId { get; set; }

        /// <summary>
        /// 外部组织名称
        /// </summary>
        [XmlElement("out_org_name")]
        public string OutOrgName { get; set; }

        /// <summary>
        /// 解约产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 子场景码
        /// </summary>
        [XmlElement("sub_biz_scene")]
        public string SubBizScene { get; set; }
    }
}
