using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserCharityRecordexistQueryResponse.
    /// </summary>
    public class AlipayUserCharityRecordexistQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否有过捐赠记录(有:true,否:false)
        /// </summary>
        [XmlElement("donation_tag")]
        public bool DonationTag { get; set; }

        /// <summary>
        /// 爱心捐赠平台捐赠的次数
        /// </summary>
        [XmlElement("donation_times")]
        public long DonationTimes { get; set; }
    }
}
