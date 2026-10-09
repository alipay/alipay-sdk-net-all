using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalUsermessageSubscriptionQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalUsermessageSubscriptionQueryModel : AopObject
    {
        /// <summary>
        /// 固定值：医保动账，5
        /// </summary>
        [XmlElement("industry_type_id")]
        public long IndustryTypeId { get; set; }

        /// <summary>
        /// 用户openId列表
        /// </summary>
        [XmlArray("open_id_list")]
        [XmlArrayItem("string")]
        public List<string> OpenIdList { get; set; }

        /// <summary>
        /// 用户id列表
        /// </summary>
        [XmlArray("user_id_list")]
        [XmlArrayItem("string")]
        public List<string> UserIdList { get; set; }
    }
}
