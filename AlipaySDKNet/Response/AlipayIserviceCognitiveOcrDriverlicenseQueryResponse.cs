using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceCognitiveOcrDriverlicenseQueryResponse.
    /// </summary>
    public class AlipayIserviceCognitiveOcrDriverlicenseQueryResponse : AopResponse
    {
        /// <summary>
        /// 地址
        /// </summary>
        [XmlElement("addr")]
        public string Addr { get; set; }

        /// <summary>
        /// 有效期限
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 识别错误的详细原因描述
        /// </summary>
        [XmlElement("error_content")]
        public string ErrorContent { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 驾驶证号码
        /// </summary>
        [XmlElement("num")]
        public string Num { get; set; }

        /// <summary>
        /// 服务器id
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [XmlElement("sex")]
        public string Sex { get; set; }

        /// <summary>
        /// 有效期起始时间
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// true:识别成功  false:识别失败
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

        /// <summary>
        /// 开放平台trace_id
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }

        /// <summary>
        /// 准驾车型
        /// </summary>
        [XmlElement("vehicle_type")]
        public string VehicleType { get; set; }
    }
}
