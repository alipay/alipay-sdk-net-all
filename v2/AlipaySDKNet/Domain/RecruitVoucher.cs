using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecruitVoucher Data Structure.
    /// </summary>
    [Serializable]
    public class RecruitVoucher : AopObject
    {
        /// <summary>
        /// 券活动id。支持商家券（创建商家券请参考https://opendocs.alipay.com/apis/01xm17）和支付券（创建支付券请参考https://opendocs.alipay.com/pre-apis/027185，仅供受邀用户使用），取值均为返回结果的activity_id字段。
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }
    }
}
