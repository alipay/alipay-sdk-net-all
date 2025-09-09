using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MiniOrderExtInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class MiniOrderExtInfoVO : AopObject
    {
        /// <summary>
        /// 买家备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 卖家备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 卖家备注旗标颜色
        /// </summary>
        [XmlElement("remark_color_flag")]
        public string RemarkColorFlag { get; set; }
    }
}
