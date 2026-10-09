using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPayCodecAcodeCertExpireModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPayCodecAcodeCertExpireModel : AopObject
    {
        /// <summary>
        /// 用户业务身份标识
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 机构类型
        /// </summary>
        [XmlElement("institution_type")]
        public string InstitutionType { get; set; }

        /// <summary>
        /// 变更时间点，会失效该时间点之前的证书（Long型）
        /// </summary>
        [XmlElement("time")]
        public long Time { get; set; }
    }
}
