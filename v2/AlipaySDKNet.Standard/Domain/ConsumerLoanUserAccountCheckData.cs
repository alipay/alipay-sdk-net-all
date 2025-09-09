using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ConsumerLoanUserAccountCheckData Data Structure.
    /// </summary>
    [Serializable]
    public class ConsumerLoanUserAccountCheckData : AopObject
    {
        /// <summary>
        /// 消费贷还款用户账户检查返回结果，若没有账单，或用户没有注册等无法查询到对应用户相关信息的情况下可不填写，但若出现手机号/身份证/姓名不匹配则应填写其中不匹配的内容
        /// </summary>
        [XmlElement("not_match_data")]
        public ConsumerLoanNotMatchData NotMatchData { get; set; }
    }
}
