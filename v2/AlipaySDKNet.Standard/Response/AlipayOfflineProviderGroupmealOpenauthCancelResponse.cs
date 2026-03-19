using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineProviderGroupmealOpenauthCancelResponse.
    /// </summary>
    public class AlipayOfflineProviderGroupmealOpenauthCancelResponse : AopResponse
    {
        /// <summary>
        /// 碰一下团餐批量解约授权开通结果对象
        /// </summary>
        [XmlElement("groupmeal_openauth_cancel_result")]
        public GroupmealOpenAuthCancelResult GroupmealOpenauthCancelResult { get; set; }
    }
}
