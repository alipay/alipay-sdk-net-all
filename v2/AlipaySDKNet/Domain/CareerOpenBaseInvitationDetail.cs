using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CareerOpenBaseInvitationDetail Data Structure.
    /// </summary>
    [Serializable]
    public class CareerOpenBaseInvitationDetail : AopObject
    {
        /// <summary>
        /// 使用SM4算法加密后的手机号密文
        /// </summary>
        [XmlElement("encrypted_mobile")]
        public string EncryptedMobile { get; set; }

        /// <summary>
        /// 外部业务单号，长度为1至64位，仅支持英文字母和数字；需要保持业务号的唯一性，相同 out_biz_no 重复提交会被拒绝，整批申请不予受理
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 外部平台的岗位id，与appId联合定位岗位
        /// </summary>
        [XmlElement("out_job_id")]
        public string OutJobId { get; set; }
    }
}
