using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NppQrCodeDTO Data Structure.
    /// </summary>
    [Serializable]
    public class NppQrCodeDTO : AopObject
    {
        /// <summary>
        /// 可用于标注特殊票种 0：正常，常规白色底 1：特殊，渐变蓝色
        /// </summary>
        [XmlElement("code_color")]
        public string CodeColor { get; set; }

        /// <summary>
        /// 码介绍
        /// </summary>
        [XmlElement("code_intro")]
        public string CodeIntro { get; set; }

        /// <summary>
        /// 可用户“票号”
        /// </summary>
        [XmlElement("code_no")]
        public string CodeNo { get; set; }

        /// <summary>
        /// 码状态（ 未核销:0 已核销:1 已作废:2 ）
        /// </summary>
        [XmlElement("code_status")]
        public string CodeStatus { get; set; }

        /// <summary>
        /// 生成二维码的字符串
        /// </summary>
        [XmlElement("code_value")]
        public string CodeValue { get; set; }
    }
}
