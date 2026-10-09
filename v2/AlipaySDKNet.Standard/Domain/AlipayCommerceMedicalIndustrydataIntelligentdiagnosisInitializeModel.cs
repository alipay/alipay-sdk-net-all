using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalIndustrydataIntelligentdiagnosisInitializeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalIndustrydataIntelligentdiagnosisInitializeModel : AopObject
    {
        /// <summary>
        /// 1-120:（传具体年龄值） 0 : 0岁（28天以上） -1: 0岁（28天内）
        /// </summary>
        [XmlElement("age")]
        public long Age { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [XmlElement("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// openid映射
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部用户user的唯一表示： 1. 如果能获取到用户uid就传支付宝uid 2. 如果获取不到支付宝uid，就用内部用户id，看是否可以加个通用标识，比如ET（外端）； 3. 获取不到用户id时，不同的用户访问时，不能传固定id，可以生成一个随机不重复的数，前缀增加个ET-UR-xxx，以便后续区分
        /// </summary>
        [XmlElement("outer_user_no")]
        public string OuterUserNo { get; set; }

        /// <summary>
        /// 外部用户类型，区分是否为标准uid或随机数
        /// </summary>
        [XmlElement("outer_user_type")]
        public string OuterUserType { get; set; }

        /// <summary>
        /// 1. 用户首次进入等都为false 2. 用户点击重新导诊的情况下为true
        /// </summary>
        [XmlElement("refresh")]
        public bool Refresh { get; set; }

        /// <summary>
        /// 请求来源，固定参数
        /// </summary>
        [XmlElement("source_type")]
        public string SourceType { get; set; }
    }
}
