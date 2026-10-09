using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdconversionConversiontypeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdconversionConversiontypeQueryModel : AopObject
    {
        /// <summary>
        /// 广告计划id。可通过灯火广告平台或者MAPI获取
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// 商家标志。获取方法：<a href="https://opendocs.alipay.com/xlight/0eucvz?pathHash=dc01fadb">principalTag自助获取</a>
        /// </summary>
        [XmlElement("principal_tag")]
        public string PrincipalTag { get; set; }
    }
}
