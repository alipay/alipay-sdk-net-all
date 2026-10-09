using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossProdAntlescenterDocusignrecipientQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossProdAntlescenterDocusignrecipientQueryModel : AopObject
    {
        /// <summary>
        /// 应用来源
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 用户签署完成跳转URL
        /// </summary>
        [XmlElement("back_url")]
        public string BackUrl { get; set; }

        /// <summary>
        /// 签署任务业务方唯一id
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 用户邮箱地址
        /// </summary>
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// 签署人recipient id，用于鉴别用户身份的
        /// </summary>
        [XmlElement("recipient_id")]
        public string RecipientId { get; set; }

        /// <summary>
        /// 签署任务流水id
        /// </summary>
        [XmlElement("sign_task_id")]
        public string SignTaskId { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
