using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantPayforprivilegeCardbinactivityDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantPayforprivilegeCardbinactivityDeleteModel : AopObject
    {
        /// <summary>
        /// 卡bin规则的外部活动唯一编号，联合对应商家的pid作为唯一键
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
