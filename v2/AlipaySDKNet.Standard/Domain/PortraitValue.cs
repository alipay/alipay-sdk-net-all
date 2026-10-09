using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PortraitValue Data Structure.
    /// </summary>
    [Serializable]
    public class PortraitValue : AopObject
    {
        /// <summary>
        /// 棋盘人群画像值对应的数量
        /// </summary>
        [XmlElement("num")]
        public string Num { get; set; }

        /// <summary>
        /// 棋盘人群画像值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
