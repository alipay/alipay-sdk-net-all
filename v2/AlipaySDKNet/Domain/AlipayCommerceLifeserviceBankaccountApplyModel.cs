using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLifeserviceBankaccountApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLifeserviceBankaccountApplyModel : AopObject
    {
        /// <summary>
        /// 默认 false，设置为 true 的时候会忽略 brand 和 site
        /// </summary>
        [XmlElement("auto_brand_site")]
        public bool AutoBrandSite { get; set; }

        /// <summary>
        /// 指定本次请求所属的品牌业务线
        /// </summary>
        [XmlElement("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// 商家账号 2088
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 指定品牌下的具体业务站点。该字段取值范围依赖于 brand的输入。
        /// </summary>
        [XmlElement("site")]
        public string Site { get; set; }
    }
}
