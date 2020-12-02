using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExternalContact Data Structure.
    /// </summary>
    [Serializable]
    public class ExternalContact : AopObject
    {
        /// <summary>
        /// 邮箱地址
        /// </summary>
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// 支付宝侧外部联系人的主键
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 工作时间段/工作性质等
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
