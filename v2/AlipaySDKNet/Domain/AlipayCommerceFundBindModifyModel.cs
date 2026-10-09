using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceFundBindModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceFundBindModifyModel : AopObject
    {
        /// <summary>
        /// 已经绑定的银行卡对应的代扣协议号。用户完成新卡的授权签约后，接口会将该协议号对应的代扣协议解绑。
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 绑卡记录过期时间，默认产期有效（1年）
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 绑卡流水号，用来标识一次绑卡行为，商户维度下需确保唯一
        /// </summary>
        [XmlElement("out_bind_no")]
        public string OutBindNo { get; set; }

        /// <summary>
        /// 用户绑卡成功后，回调到基金APP的URL
        /// </summary>
        [XmlElement("redirect_url")]
        public string RedirectUrl { get; set; }
    }
}
