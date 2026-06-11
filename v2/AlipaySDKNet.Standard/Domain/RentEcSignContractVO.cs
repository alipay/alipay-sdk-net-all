using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentEcSignContractVO Data Structure.
    /// </summary>
    [Serializable]
    public class RentEcSignContractVO : AopObject
    {
        /// <summary>
        /// 租赁电子合同模板code
        /// </summary>
        [XmlElement("ec_template_code")]
        public string EcTemplateCode { get; set; }

        /// <summary>
        /// 已签署合同文件地址，签署成功才有
        /// </summary>
        [XmlElement("file_url")]
        public string FileUrl { get; set; }

        /// <summary>
        /// 签署状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
