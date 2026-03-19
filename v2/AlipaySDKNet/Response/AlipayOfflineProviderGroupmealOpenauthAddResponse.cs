using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineProviderGroupmealOpenauthAddResponse.
    /// </summary>
    public class AlipayOfflineProviderGroupmealOpenauthAddResponse : AopResponse
    {
        /// <summary>
        /// 团餐碰一下签约授权开通结果对象
        /// </summary>
        [XmlElement("groupmeal_openauth_add_result")]
        public GroupmealOpenAuthAddResult GroupmealOpenauthAddResult { get; set; }
    }
}
