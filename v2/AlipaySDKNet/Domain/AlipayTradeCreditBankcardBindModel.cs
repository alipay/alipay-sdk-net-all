using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeCreditBankcardBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeCreditBankcardBindModel : AopObject
    {
        /// <summary>
        /// 已签约协议号，当redirection_data为空时，此项必填
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 业务场景类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 证件号，用户身份证号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 0代表身份证
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 是否需要同人校验，true表示需要校验用户身份
        /// </summary>
        [XmlElement("need_check")]
        public bool NeedCheck { get; set; }

        /// <summary>
        /// 外部绑卡流水号，同一业务场景下需确保唯一
        /// </summary>
        [XmlElement("out_bind_no")]
        public string OutBindNo { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        [XmlElement("real_name")]
        public string RealName { get; set; }

        /// <summary>
        /// 回跳schema地址，用于唤起支付宝选卡组件
        /// </summary>
        [XmlElement("redirect_url")]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// 代扣签约页面返回数据，当agreement_no为空时，此项必填
        /// </summary>
        [XmlElement("redirection_data")]
        public string RedirectionData { get; set; }
    }
}
