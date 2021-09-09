using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingActivityConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingActivityConsultModel : AopObject
    {
        /// <summary>
        /// 待咨询的活动信息列表
        /// </summary>
        [XmlArray("consult_activity_info_list")]
        [XmlArrayItem("consult_activity_info")]
        public List<ConsultActivityInfo> ConsultActivityInfoList { get; set; }

        /// <summary>
        /// 领券的用户uid
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
