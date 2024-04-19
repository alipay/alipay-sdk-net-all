using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EntryHealthPersonInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EntryHealthPersonInfo : AopObject
    {
        /// <summary>
        /// 参数代表候选人的表单号，根据数据库id加盐生成，字符串类型，供应商拿到该单号之后需要为该单号初始化信息用于登陆供应商系统，该字段不会为空
        /// </summary>
        [XmlElement("form_no")]
        public string FormNo { get; set; }

        /// <summary>
        /// 该参数用于确认候选人人员类型，根据候选人层级来确定是普通员工还是高管，根据层级来决定，字符串类型，供应商拿到该数据后会根据候选人的类型不同做不同的初始化，为高管提供VIP服务
        /// </summary>
        [XmlElement("user_type")]
        public string UserType { get; set; }
    }
}
