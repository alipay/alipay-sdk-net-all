using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EduOrderExtendParams Data Structure.
    /// </summary>
    [Serializable]
    public class EduOrderExtendParams : AopObject
    {
        /// <summary>
        /// 银行备注信息
        /// </summary>
        [XmlElement("bank_memo")]
        public string BankMemo { get; set; }

        /// <summary>
        /// 系统商编号 该参数作为系统商返佣数据提取的依据，请填写系统商签约协议的PID
        /// </summary>
        [XmlElement("sys_service_provider_id")]
        public string SysServiceProviderId { get; set; }
    }
}
