using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenIotbpaasQrcodeCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenIotbpaasQrcodeCreateModel : AopObject
    {
        /// <summary>
        /// 文本内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 二维码大小，默认M，取值L、M、S
        /// </summary>
        [XmlElement("size")]
        public string Size { get; set; }

        /// <summary>
        /// 二维码样式，默认BLANK，取值同码平台定义，有NOSTYLE、BLACK可选
        /// </summary>
        [XmlElement("style")]
        public string Style { get; set; }
    }
}
