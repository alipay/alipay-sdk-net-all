using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserBillDetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserBillDetailQueryModel : AopObject
    {
        /// <summary>
        /// 账单内部业务流水号，是查询单条账单的必传参数
        /// </summary>
        [XmlElement("biz_in_no")]
        public string BizInNo { get; set; }
    }
}
