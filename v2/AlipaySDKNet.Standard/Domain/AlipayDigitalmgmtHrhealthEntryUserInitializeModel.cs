using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDigitalmgmtHrhealthEntryUserInitializeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDigitalmgmtHrhealthEntryUserInitializeModel : AopObject
    {
        /// <summary>
        /// 账号，候选人登陆爱康系统的账号，由供应商系统生成传回，用于给候选人发送邮件时带入，让候选人可以登陆供应商系统
        /// </summary>
        [XmlElement("account")]
        public string Account { get; set; }

        /// <summary>
        /// data_key用于校验供应商的权限，每一个接入系统的供应商只有一个该参数，供应商来对接时蚂蚁生成唯一参数线下给到供应商侧
        /// </summary>
        [XmlElement("data_key")]
        public string DataKey { get; set; }

        /// <summary>
        /// form_no，唯一，用于确定唯一的候选人，是通过蚂蚁入职体检系统的数据库id加盐生成，字符串类型，用来确定唯一的候选人，代表该候选人的账号密码已经生成，可以进行下一步操作
        /// </summary>
        [XmlElement("form_no")]
        public string FormNo { get; set; }

        /// <summary>
        /// 密码，候选人登陆供应商系统的密码，字符串类型，由供应商系统生成并传入，蚂蚁系统发送邮件给候选人时带入，候选人凭借此密码登陆供应商系统
        /// </summary>
        [XmlElement("password")]
        public string Password { get; set; }
    }
}
