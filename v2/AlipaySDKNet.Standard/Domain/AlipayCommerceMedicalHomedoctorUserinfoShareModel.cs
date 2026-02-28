using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHomedoctorUserinfoShareModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHomedoctorUserinfoShareModel : AopObject
    {
        /// <summary>
        /// 蚂蚁健康访问令牌。通过该令牌调用需要授权接口
        /// </summary>
        [XmlElement("aq_access_token")]
        public string AqAccessToken { get; set; }

        /// <summary>
        /// 蚂蚁健康用户对外开放OPEN_ID
        /// </summary>
        [XmlElement("aq_open_id")]
        public string AqOpenId { get; set; }
    }
}
