using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ChangeModel Data Structure.
    /// </summary>
    [Serializable]
    public class ChangeModel : AopObject
    {
        /// <summary>
        /// 支付宝协议支付的协议号。SCHOOL_DEDUCT_OPEN时返回
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 变更状态。可选的字段枚举说明：{SUCCESS:变更成功;FAIL:变更失败}
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 变更类型。可选的字段枚举说明：{SCHOOL_DEDUCT_OPEN:校园支付开通;SCHOOL_DEDUCT_CLOSE:校园支付关闭}
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
