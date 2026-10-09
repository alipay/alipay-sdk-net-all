using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalFincloudFinsaasBcmDigitalrmbSendResponse.
    /// </summary>
    public class DatadigitalFincloudFinsaasBcmDigitalrmbSendResponse : AopResponse
    {
        /// <summary>
        /// 下个页面阶段
        /// </summary>
        [XmlElement("page_stage")]
        public string PageStage { get; set; }

        /// <summary>
        /// 奖品code
        /// </summary>
        [XmlElement("prize_code")]
        public string PrizeCode { get; set; }

        /// <summary>
        /// 奖品价格，单位：分
        /// </summary>
        [XmlElement("prize_price")]
        public long PrizePrice { get; set; }

        /// <summary>
        /// 发放数币结果
        /// </summary>
        [XmlElement("send_result")]
        public string SendResult { get; set; }
    }
}
