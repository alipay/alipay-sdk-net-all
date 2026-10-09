using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RightsFormItemValues Data Structure.
    /// </summary>
    [Serializable]
    public class RightsFormItemValues : AopObject
    {
        /// <summary>
        /// 企业统一社会信用代码
        /// </summary>
        [XmlElement("crn")]
        public string Crn { get; set; }

        /// <summary>
        /// 联系人邮箱
        /// </summary>
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [XmlElement("ep_name")]
        public string EpName { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        [XmlElement("legal_person")]
        public string LegalPerson { get; set; }

        /// <summary>
        /// 用户的支付宝用户open_id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 表单中的其他字段
        /// </summary>
        [XmlArray("other_fields")]
        [XmlArrayItem("label_value")]
        public List<LabelValue> OtherFields { get; set; }

        /// <summary>
        /// 联系人手机号
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 表单提交时间
        /// </summary>
        [XmlElement("submit_time")]
        public string SubmitTime { get; set; }

        /// <summary>
        /// 用户的支付宝id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
