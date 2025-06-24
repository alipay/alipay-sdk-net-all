using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialAntforestRewardCertifyResponse.
    /// </summary>
    public class AlipaySocialAntforestRewardCertifyResponse : AopResponse
    {
        /// <summary>
        /// 实体证书上打印的证书编号
        /// </summary>
        [XmlElement("cert_id")]
        public string CertId { get; set; }

        /// <summary>
        /// 用于实体证书上打印的名称，仅当scene_code='CERT_ENTITY'时有返回值
        /// </summary>
        [XmlElement("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// true-有对应奖励的领取资格 false-无资格
        /// </summary>
        [XmlElement("has_reward")]
        public bool HasReward { get; set; }
    }
}
