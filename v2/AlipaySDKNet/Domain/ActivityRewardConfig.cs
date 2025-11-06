using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ActivityRewardConfig Data Structure.
    /// </summary>
    [Serializable]
    public class ActivityRewardConfig : AopObject
    {
        /// <summary>
        /// 奖品副标题
        /// </summary>
        [XmlElement("sub_title")]
        public string SubTitle { get; set; }

        /// <summary>
        /// 主标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 权益奖品单位
        /// </summary>
        [XmlElement("unit")]
        public string Unit { get; set; }

        /// <summary>
        /// 权益奖品数目，仅做展示使用。单位包含个、折等，由业务运营定义
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
