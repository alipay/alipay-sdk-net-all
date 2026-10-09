using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundIdentitypayOrganizationSignModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundIdentitypayOrganizationSignModel : AopObject
    {
        /// <summary>
        /// 签约场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 小区规模
        /// </summary>
        [XmlElement("member_count")]
        public long MemberCount { get; set; }

        /// <summary>
        /// 外部组织所在具体地址
        /// </summary>
        [XmlElement("out_org_address")]
        public string OutOrgAddress { get; set; }

        /// <summary>
        /// 外部组织所在区
        /// </summary>
        [XmlElement("out_org_area")]
        public string OutOrgArea { get; set; }

        /// <summary>
        /// 外部组织所在市
        /// </summary>
        [XmlElement("out_org_city")]
        public string OutOrgCity { get; set; }

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
        /// 外部组织所在省
        /// </summary>
        [XmlElement("out_org_province")]
        public string OutOrgProvince { get; set; }

        /// <summary>
        /// 外部组织所在街道
        /// </summary>
        [XmlElement("out_org_street")]
        public string OutOrgStreet { get; set; }

        /// <summary>
        /// 签约产品码
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
