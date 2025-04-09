using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CarfinStatusNotifyOther Data Structure.
    /// </summary>
    [Serializable]
    public class CarfinStatusNotifyOther : AopObject
    {
        /// <summary>
        /// 终审未提报原因码值
        /// </summary>
        [XmlElement("approve_not_submit_code")]
        public string ApproveNotSubmitCode { get; set; }

        /// <summary>
        /// 终审未提交原因描述
        /// </summary>
        [XmlElement("approve_not_submit_msg")]
        public string ApproveNotSubmitMsg { get; set; }

        /// <summary>
        /// 购车方式
        /// </summary>
        [XmlElement("pay_method")]
        public string PayMethod { get; set; }
    }
}
