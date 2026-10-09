using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentDeductInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class RentDeductInfoVO : AopObject
    {
        /// <summary>
        /// 代扣签约场景
        /// </summary>
        [XmlElement("sign_scene")]
        public string SignScene { get; set; }

        /// <summary>
        /// 签约状态
        /// </summary>
        [XmlElement("sign_status")]
        public string SignStatus { get; set; }

        /// <summary>
        /// 签约时间
        /// </summary>
        [XmlElement("sign_time")]
        public string SignTime { get; set; }
    }
}
