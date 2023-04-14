using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryGovFastmodeSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryGovFastmodeSyncModel : AopObject
    {
        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 是否包含敏感信息，例如身份证号码
        /// </summary>
        [XmlElement("desensitization")]
        public bool Desensitization { get; set; }

        /// <summary>
        /// 机构回传键值对参数
        /// </summary>
        [XmlArray("keyword_list")]
        [XmlArrayItem("common_keyword")]
        public List<CommonKeyword> KeywordList { get; set; }

        /// <summary>
        /// 蚂蚁开放平台OpenId
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 机构编码，bizType的二级分类，不传默认为“normal”
        /// </summary>
        [XmlElement("org_code")]
        public string OrgCode { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
