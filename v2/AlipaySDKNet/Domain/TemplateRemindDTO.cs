using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TemplateRemindDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TemplateRemindDTO : AopObject
    {
        /// <summary>
        /// 提醒默认的提前秒数，3600-24×3600秒之间。即将到期时提醒用户使用卡券，不设置则按照券类型默认时间提醒，一般为36小时。支持以 $动态参数$ 形式的自定义动态参数传值。
        /// </summary>
        [XmlElement("offset")]
        public string Offset { get; set; }
    }
}
