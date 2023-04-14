using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandIndirectBindConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandIndirectBindConsultModel : AopObject
    {
        /// <summary>
        /// 申请单ID，与out_biz_no二选一
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 外部业务号，与order_no二选一
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
