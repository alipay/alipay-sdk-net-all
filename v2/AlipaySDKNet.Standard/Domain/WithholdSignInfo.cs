using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WithholdSignInfo Data Structure.
    /// </summary>
    [Serializable]
    public class WithholdSignInfo : AopObject
    {
        /// <summary>
        /// 支付宝系统中用以唯一标识用户签约记录的编号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 代扣签约结协议状态
        /// </summary>
        [XmlElement("agreement_status")]
        public string AgreementStatus { get; set; }

        /// <summary>
        /// 协议签约场景码,商户和支付宝签约时确定
        /// </summary>
        [XmlElement("sign_scene")]
        public string SignScene { get; set; }

        /// <summary>
        /// 签约时间，签约结果同步时非空
        /// </summary>
        [XmlElement("sign_time")]
        public string SignTime { get; set; }

        /// <summary>
        /// 解约时间，解约结果同步时非空
        /// </summary>
        [XmlElement("unsign_time")]
        public string UnsignTime { get; set; }
    }
}
