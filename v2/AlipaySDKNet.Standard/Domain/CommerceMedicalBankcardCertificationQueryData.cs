using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CommerceMedicalBankcardCertificationQueryData Data Structure.
    /// </summary>
    [Serializable]
    public class CommerceMedicalBankcardCertificationQueryData : AopObject
    {
        /// <summary>
        /// 响应时间戳。 格式为 yyyy-MM-dd HH:mm:ss。
        /// </summary>
        [XmlElement("gmt_response")]
        public string GmtResponse { get; set; }

        /// <summary>
        /// 用户是否已经绑定银行卡,Y或者N
        /// </summary>
        [XmlElement("is_bankcard_certified")]
        public string IsBankcardCertified { get; set; }
    }
}
