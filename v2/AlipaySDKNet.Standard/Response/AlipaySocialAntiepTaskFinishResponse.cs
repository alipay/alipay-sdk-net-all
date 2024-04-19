using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialAntiepTaskFinishResponse.
    /// </summary>
    public class AlipaySocialAntiepTaskFinishResponse : AopResponse
    {
        /// <summary>
        /// 完成任务结果的描述
        /// </summary>
        [XmlElement("biz_desc")]
        public string BizDesc { get; set; }

        /// <summary>
        /// 完成任务的处理结果码
        /// </summary>
        [XmlElement("biz_result_code")]
        public string BizResultCode { get; set; }

        /// <summary>
        /// 任务完成的结果如果是失败时，是否可重试， 如果biz_success=false，则biz_retriable=true时代表需要重试的异常， 如果biz_retriable=false时，则代表不能重试，含义可分为两种：1、不需要重试的异常，比如重试的请求被幂等了、2、或者是即使重试了也成功不了的异常，比如参数缺失、配置缺失等，这种错误需要在验证期间就避免掉，验证无误了再上线！
        /// </summary>
        [XmlElement("biz_retriable")]
        public bool BizRetriable { get; set; }

        /// <summary>
        /// 完成任务的处理结果是否成功，如果biz_success=true，则代表完成任务成功，如果biz_success=false，需看biz_retriable的值是true代表可重试，biz_retriable为false时则不可重试
        /// </summary>
        [XmlElement("biz_success")]
        public bool BizSuccess { get; set; }
    }
}
