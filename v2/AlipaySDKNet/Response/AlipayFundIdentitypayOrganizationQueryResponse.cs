using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundIdentitypayOrganizationQueryResponse.
    /// </summary>
    public class AlipayFundIdentitypayOrganizationQueryResponse : AopResponse
    {
        /// <summary>
        /// 物业相关信息
        /// </summary>
        [XmlElement("business_params")]
        public string BusinessParams { get; set; }

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
        /// 已签约-NORMAL、未签约-CLOSED
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
