using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditSceneprodLprQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditSceneprodLprQueryModel : AopObject
    {
        /// <summary>
        /// 贷款方案上贷款年利率为16.2%，则查询基于LPR基准利率浮动数据时，参数为0.162
        /// </summary>
        [XmlElement("loan_rate")]
        public string LoanRate { get; set; }
    }
}
