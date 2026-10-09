using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdBudgetapplyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdBudgetapplyQueryModel : AopObject
    {
        /// <summary>
        /// 第三方申请单号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 商家标志，用于权限校验
        /// </summary>
        [XmlElement("principal_tag")]
        public string PrincipalTag { get; set; }
    }
}
