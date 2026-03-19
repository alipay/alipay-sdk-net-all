using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalAqUsercertifyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalAqUsercertifyQueryModel : AopObject
    {
        /// <summary>
        /// 授权码
        /// </summary>
        [XmlElement("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// 用于标记AQ用户在应用下的唯一标识
        /// </summary>
        [XmlElement("aq_sub_id")]
        public string AqSubId { get; set; }

        /// <summary>
        /// 应用id
        /// </summary>
        [XmlElement("biz_app_id")]
        public string BizAppId { get; set; }
    }
}
