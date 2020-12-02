using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HealthCard Data Structure.
    /// </summary>
    [Serializable]
    public class HealthCard : AopObject
    {
        /// <summary>
        /// 用户出生日期
        /// </summary>
        [XmlElement("birthday")]
        public string Birthday { get; set; }

        /// <summary>
        /// 用户健康卡对应身份证号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 由卫健委机构统一生成的健康卡卡号
        /// </summary>
        [XmlElement("health_card_no")]
        public string HealthCardNo { get; set; }

        /// <summary>
        /// 健康卡所属用户的真实姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 用户性别，其中1代表男性，2代表女性
        /// </summary>
        [XmlElement("sex")]
        public string Sex { get; set; }
    }
}
