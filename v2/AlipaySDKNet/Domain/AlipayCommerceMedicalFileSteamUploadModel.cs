using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalFileSteamUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalFileSteamUploadModel : AopObject
    {
        /// <summary>
        /// 业务流水号，对应支付宝SAAS订单ID
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 文件二进制流转换后的十六进制字符串
        /// </summary>
        [XmlElement("file_content")]
        public string FileContent { get; set; }

        /// <summary>
        /// 文件编码
        /// </summary>
        [XmlElement("file_no")]
        public string FileNo { get; set; }

        /// <summary>
        /// 文件类型
        /// </summary>
        [XmlElement("file_type")]
        public string FileType { get; set; }

        /// <summary>
        /// 场景类型
        /// </summary>
        [XmlElement("scene_type")]
        public string SceneType { get; set; }
    }
}
