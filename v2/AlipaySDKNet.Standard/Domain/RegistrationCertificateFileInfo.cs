using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RegistrationCertificateFileInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RegistrationCertificateFileInfo : AopObject
    {
        /// <summary>
        /// 文件路径
        /// </summary>
        [XmlElement("file_path")]
        public string FilePath { get; set; }

        /// <summary>
        /// 文件标签 VC_1_2:机动车登记证1-2页 VC_3_4:机动车登记证3-4页 VC_5_6:机动车登记证5-6页 VC_7_8:机动车登记证7-8页 VC_9_10:机动车登记证9-10页 VC_11_12:机动车登记证11-12页
        /// </summary>
        [XmlElement("tag")]
        public string Tag { get; set; }
    }
}
