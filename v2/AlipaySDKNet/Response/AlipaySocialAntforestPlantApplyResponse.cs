using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialAntforestPlantApplyResponse.
    /// </summary>
    public class AlipaySocialAntforestPlantApplyResponse : AopResponse
    {
        /// <summary>
        /// 时间戳，记录的是业务在蚂蚁森林完成时间，可保存用户核对
        /// </summary>
        [XmlElement("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 证书ID或者其他ID，表示一次兑换的凭证
        /// </summary>
        [XmlElement("certificate_id")]
        public string CertificateId { get; set; }

        /// <summary>
        /// 当前兑换树种账户的可用能量值
        /// </summary>
        [XmlElement("current_energy")]
        public long CurrentEnergy { get; set; }
    }
}
