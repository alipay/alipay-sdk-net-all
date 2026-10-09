using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneOpenprodTokenGenerateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneOpenprodTokenGenerateModel : AopObject
    {
        /// <summary>
        /// 身份证号
        /// </summary>
        [XmlElement("id_card_no")]
        public string IdCardNo { get; set; }

        /// <summary>
        /// 端外服务商来源标识
        /// </summary>
        [XmlElement("outbound_source")]
        public string OutboundSource { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 用户的真实姓名
        /// </summary>
        [XmlElement("real_name")]
        public string RealName { get; set; }
    }
}
