using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FinAttachment Data Structure.
    /// </summary>
    [Serializable]
    public class FinAttachment : AopObject
    {
        /// <summary>
        /// 协议编码，当type为AGREEMENT时必填
        /// </summary>
        [XmlElement("agreement_code")]
        public string AgreementCode { get; set; }

        /// <summary>
        /// 文件路径
        /// </summary>
        [XmlElement("file_path")]
        public string FilePath { get; set; }

        /// <summary>
        /// 文件后缀
        /// </summary>
        [XmlElement("file_suffix")]
        public string FileSuffix { get; set; }

        /// <summary>
        /// 文件名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 附件类型: AGREEMENT：协议 PERSON_ID_CARD_FRONT：法人身份证正面影像件 PERSON_ID_CARD_BACK：法人身份证反面影像件 COMPANY_LICENSE：营业执照影像件
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
