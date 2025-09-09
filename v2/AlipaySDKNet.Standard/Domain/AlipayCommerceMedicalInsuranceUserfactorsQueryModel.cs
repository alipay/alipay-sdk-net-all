using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalInsuranceUserfactorsQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalInsuranceUserfactorsQueryModel : AopObject
    {
        /// <summary>
        /// 用户TOKEN值，保单、权限等查询等页面跳转之后前端会带过去和用户信息关联的user_token字段，用于外部查询用户三要素。
        /// </summary>
        [XmlElement("user_token")]
        public string UserToken { get; set; }
    }
}
