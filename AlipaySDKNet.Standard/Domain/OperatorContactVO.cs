using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OperatorContactVO Data Structure.
    /// </summary>
    [Serializable]
    public class OperatorContactVO : AopObject
    {
        /// <summary>
        /// 联系方式类型，取值参考OperatorContactTypeEnum 范围如下： 1=手机 2=电话 3=Email 8=钉钉
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 联系方式值，类型由type决定。 若type=1，则value填手机号码； 若type=3，则value填Email地址； 以此类推
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
