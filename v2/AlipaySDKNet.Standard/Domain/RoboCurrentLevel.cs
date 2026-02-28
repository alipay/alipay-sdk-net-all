using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RoboCurrentLevel Data Structure.
    /// </summary>
    [Serializable]
    public class RoboCurrentLevel : AopObject
    {
        /// <summary>
        /// 左侧座椅加热档位，0是未设置，1，2，3档
        /// </summary>
        [XmlElement("left")]
        public long Left { get; set; }

        /// <summary>
        /// 右侧座椅加热档位，0是未设置，1，2，3档
        /// </summary>
        [XmlElement("right")]
        public long Right { get; set; }
    }
}
