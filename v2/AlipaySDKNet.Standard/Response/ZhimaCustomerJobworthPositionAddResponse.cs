using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCustomerJobworthPositionAddResponse.
    /// </summary>
    public class ZhimaCustomerJobworthPositionAddResponse : AopResponse
    {
        /// <summary>
        /// 岗位信息ID
        /// </summary>
        [XmlElement("position_id")]
        public string PositionId { get; set; }

        /// <summary>
        /// 业务错误
        /// </summary>
        [XmlElement("sub_code")]
        public string SubCode { get; set; }

        /// <summary>
        /// 业务错误信息
        /// </summary>
        [XmlElement("sub_msg")]
        public string SubMsg { get; set; }
    }
}
