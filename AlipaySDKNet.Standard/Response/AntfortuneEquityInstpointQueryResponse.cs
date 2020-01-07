using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntfortuneEquityInstpointQueryResponse.
    /// </summary>
    public class AntfortuneEquityInstpointQueryResponse : AopResponse
    {
        /// <summary>
        /// 当前积分值，表示用户在商户下的可用积分总值
        /// </summary>
        [XmlElement("point_score")]
        public long PointScore { get; set; }
    }
}
