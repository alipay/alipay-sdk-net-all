using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppCommunityThirdpartycommunityCreateResponse.
    /// </summary>
    public class AlipayEbppCommunityThirdpartycommunityCreateResponse : AopResponse
    {
        /// <summary>
        /// 行业内部生成的物业小区编号
        /// </summary>
        [XmlElement("community_id")]
        public string CommunityId { get; set; }

        /// <summary>
        /// 对应请求参数「物业公司 community_property_company」「公司缩写 short_name」 后续小区绑定物业公司实现快速关联。物业公司信息更新时使用。
        /// </summary>
        [XmlElement("property_company_short_name")]
        public string PropertyCompanyShortName { get; set; }
    }
}
