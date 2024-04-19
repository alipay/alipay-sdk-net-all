using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntfortuneEquityInstpointSendResponse.
    /// </summary>
    public class AntfortuneEquityInstpointSendResponse : AopResponse
    {
        /// <summary>
        /// 积分发放流水，发放结果为true时，流水号可唯一索引本次发放记录
        /// </summary>
        [XmlElement("point_trans_no")]
        public string PointTransNo { get; set; }

        /// <summary>
        /// 积分发放结果，true：成功；false：失败
        /// </summary>
        [XmlElement("send_result")]
        public bool SendResult { get; set; }
    }
}
