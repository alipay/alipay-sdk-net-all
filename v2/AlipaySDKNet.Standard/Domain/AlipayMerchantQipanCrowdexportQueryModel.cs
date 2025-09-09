using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantQipanCrowdexportQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantQipanCrowdexportQueryModel : AopObject
    {
        /// <summary>
        /// 外部业务号，用于查询同步任务
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
