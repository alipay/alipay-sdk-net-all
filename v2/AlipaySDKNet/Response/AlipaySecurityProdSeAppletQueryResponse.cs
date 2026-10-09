using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdSeAppletQueryResponse.
    /// </summary>
    public class AlipaySecurityProdSeAppletQueryResponse : AopResponse
    {
        /// <summary>
        /// apdu_commands:apdu指令列表，逗号分隔，根据该值确定硬件端对applet的具体操作
        /// </summary>
        [XmlElement("apdu_commands")]
        public string ApduCommands { get; set; }

        /// <summary>
        /// 操作类型，唯一，传递tsm的具体操作，厂测程序提供
        /// </summary>
        [XmlElement("opt_type")]
        public long OptType { get; set; }

        /// <summary>
        /// result_code:调用tsm返回的结果码，根据该字段可以知道本次调用的状态
        /// </summary>
        [XmlElement("result_code")]
        public long ResultCode { get; set; }

        /// <summary>
        /// step:表示调用tsm过程中的步骤数
        /// </summary>
        [XmlElement("step")]
        public long Step { get; set; }

        /// <summary>
        /// step_code:tsm返回的步骤编码，供多语使用
        /// </summary>
        [XmlElement("step_code")]
        public long StepCode { get; set; }

        /// <summary>
        /// sub_opt_type:子操作类型，tsm返回给厂测程序
        /// </summary>
        [XmlElement("sub_opt_type")]
        public long SubOptType { get; set; }

        /// <summary>
        /// total_step:表示调用tsm的总步骤数
        /// </summary>
        [XmlElement("total_step")]
        public long TotalStep { get; set; }
    }
}
