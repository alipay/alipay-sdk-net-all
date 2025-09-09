using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OperatorData Data Structure.
    /// </summary>
    [Serializable]
    public class OperatorData : AopObject
    {
        /// <summary>
        /// 头像链接
        /// </summary>
        [XmlElement("avatar")]
        public string Avatar { get; set; }

        /// <summary>
        /// 操作员id
        /// </summary>
        [XmlElement("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 操作人姓名
        /// </summary>
        [XmlElement("operator_name")]
        public string OperatorName { get; set; }

        /// <summary>
        /// 操作员openid
        /// </summary>
        [XmlElement("operator_open_id")]
        public string OperatorOpenId { get; set; }
    }
}
