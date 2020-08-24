using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TemplateStyleDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TemplateStyleDTO : AopObject
    {
        /// <summary>
        /// 卡券整体背颜色，用RGB值以rgb(X,X,X)形式表示。支持以 $动态参数$ 形式的自定义动态参数传值。
        /// </summary>
        [XmlElement("background_color")]
        public string BackgroundColor { get; set; }
    }
}
