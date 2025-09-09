using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FaceCheckInitResult Data Structure.
    /// </summary>
    [Serializable]
    public class FaceCheckInitResult : AopObject
    {
        /// <summary>
        /// 校验单据号
        /// </summary>
        [XmlElement("verify_biz_no")]
        public string VerifyBizNo { get; set; }

        /// <summary>
        /// 校验id
        /// </summary>
        [XmlElement("verify_id")]
        public string VerifyId { get; set; }

        /// <summary>
        /// 校验url
        /// </summary>
        [XmlElement("verify_url")]
        public string VerifyUrl { get; set; }
    }
}
